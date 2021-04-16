using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
/// <summary>
/// Ana Maghradze
/// red ID: 82335646
/// </summary>
namespace BookStore
{
    public partial class BookStoreForm : Form
    {
        private SqlConnection connection = new SqlConnection(DataHandler.ConnectionString);
        private SqlDataAdapter adapter;
        public static SqlCommand scmd;        
        List<OrderDetails> orderDetailsList = new List<OrderDetails>();
        List<decimal> Lines = new List<decimal>();
        DataHandler dh = new DataHandler();
        int orderID;
        Order order;

        object currentCustomer;
        decimal subtotal = 0;
        decimal total = 0;
        decimal tax = 0;

        public BookStoreForm()
        {
            InitializeComponent();
            DisplayCustomers();
            DisplayBooks();
            ResetAll();
        }

        private void DisplayBooks()
        {
            string queryStr = "select * from Books";
            dh.FillComboboxWithData(queryStr, comboBox1, "-- Select Book Title --", "Title", "Title");
        }

        private void DisplayCustomers()
        {
            string queryStr = "select (FirstName + ' ' + LastName) as FullName, Email, Phone, Address, City, Zip FROM Customers";
            dh.FillComboboxWithData(queryStr, CustomerComboBox, "-- Select Customer --", "FullName", "FullName");
        }

        // if index of selcted value of combobox changes
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Books", connection);
            adapter.Fill(dt);
            int index = comboBox1.SelectedIndex - 1;

            if (index >= 0)
            {
                AuthorTextBox.Text = dt.Rows[index]["Author"].ToString(); ;
                IsbnTextBox.Text = dt.Rows[index]["ISBN"].ToString();
                PriceTextBox.Text = dt.Rows[index]["Price"].ToString();
                QuantityTextBox.Text = "0";
            }
            else
            {
                AuthorTextBox.Text = "";
                IsbnTextBox.Text = "";
                PriceTextBox.Text = "0";
                QuantityTextBox.Text = "0";
            }
        }

        // if index of selcted value of combobox changes
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // prevent user from changing customer after adding the order to cart 
            if (DataList.Rows.Count == 0)
            {
                currentCustomer = CustomerComboBox.SelectedValue.ToString();
            }
            else if (CustomerComboBox.SelectedValue != currentCustomer)
            {
                CustomerComboBox.SelectedValue = currentCustomer;
                MessageBox.Show("Please, confirm or cancel the order for customer:\n" + currentCustomer, "Selected Customer Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // prevent user from entering letters or other characters in quantity textbox
        private void ValidateQuantity(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // when user clicks 'add to cart' button
        private void button1_Click(object sender, EventArgs e)
        {
            // if user chooses '-- Select Book --' option
            if (comboBox1.SelectedIndex == 0 || AuthorTextBox.Text == "")
            {
                MessageBox.Show("Please, choose a book from the list.", "Missing order details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
            }
            // if quantity box value starts with 0 or is empty
            else if (QuantityTextBox.Text == "" || QuantityTextBox.Text.StartsWith("0"))
            {
                MessageBox.Show("Please, enter the valid number of books.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Focus();
            }
            // if user chooses '-- Select Customer --" option
            else if (CustomerComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please, choose the customer", "Missing Order Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerComboBox.Focus();
            }
            else
            {
                string BookID = IsbnTextBox.Text.ToString();
                var index = this.DataList.Rows.Add(); // add new row and get index of this row
                var lineTotal = decimal.Parse(PriceTextBox.Text.TrimStart('$')) * decimal.Parse(QuantityTextBox.Text);
                this.DataList.Rows[index].Cells[0].Value = comboBox1.SelectedValue.ToString();
                this.DataList.Rows[index].Cells[1].Value = decimal.Parse(PriceTextBox.Text.TrimStart('$')).ToString("C2");
                this.DataList.Rows[index].Cells[2].Value = QuantityTextBox.Text;
                this.DataList.Rows[index].Cells[3].Value = lineTotal.ToString("C2");

                orderDetailsList.Add(new OrderDetails(BookID, int.Parse(QuantityTextBox.Text), lineTotal));
                this.Lines.Add(lineTotal); // store Line Total values in the list when book is added to the DataGridView
                CalculateTotalAmount(); // calculate total amount for user to pay
            }
        }

        // calculate total amount, assign subtotal, tax and total variables with corresponding values
        private void CalculateTotalAmount()
        {
            this.subtotal = 0;
            Lines.ForEach(line => this.subtotal += line);
            this.tax = this.subtotal / 10;
            this.total = this.subtotal + this.tax;
            SubtotalTextBox.Text = this.subtotal.ToString("C2");
            TaxTextBox.Text = this.tax.ToString("C2");
            TotalTextBox.Text = this.total.ToString("C2");
        }

        // if user clicks 'Confirm Order' button
        private void button2_Click(object sender, EventArgs e)
        {
            // if no book chosen, warn user with message
            if (Lines.Count == 0)
            {
                MessageBox.Show("Please, add a book to the list.", "Missing order details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
            }
            else
            {
                DialogResult response = MessageBox.Show("Are you sure you want confirm the order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (response == DialogResult.Yes)
                {
                    // record order                    
                    DateTime currentDate = DateTime.Now;
                    order = new Order(CustomerComboBox.SelectedValue.ToString(), decimal.Parse(SubtotalTextBox.Text.TrimStart('$')), decimal.Parse(TotalTextBox.Text.TrimStart('$')), decimal.Parse(TaxTextBox.Text.TrimStart('$')), currentDate);
                    RecordOrder(order);
                    // record order details 
                    RecordOrderDetails(orderDetailsList);
                    // show order report
                    string orders = "";
                    for (var i = 0; i < DataList.Rows.Count; i++)
                    {
                        orders += $"------------------------------------------------------------------\n" +
                            $"Book Title:  {DataList.Rows[i].Cells[0].Value.ToString()}\n" +
                            $"Book Price:  {DataList.Rows[i].Cells[1].Value.ToString()}\n" +
                            $"Quantity:     {DataList.Rows[i].Cells[2].Value.ToString()}\n" +
                            $"Lines Total: {DataList.Rows[i].Cells[3].Value.ToString()}\n";
                    }
                    string reportText = $"Customer:    {CustomerComboBox.SelectedValue.ToString()}\n" +
                            $"Order Date:  {currentDate}\n\n" +
                            $"Ordered Books:\n{orders}" +
                            $"------------------------------------------------------------------\n\n" +
                            $"Subtotal: {SubtotalTextBox.Text}\n" +
                            $"Tax:          {TaxTextBox.Text}\n" +
                            $"Total:       {TotalTextBox.Text}";
                    ResetAll();
                    MessageBox.Show(reportText, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // if user clicks 'Cancel Order' button
        private void button3_Click(object sender, EventArgs e)
        {
            // get confirmation from user to cancel the order
            DialogResult response = MessageBox.Show("Are you sure you want cancel the order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (response == DialogResult.Yes)
            {
                ResetAll();
            }
        }

        private void ResetAll()
        {
            AuthorTextBox.Text = "";
            IsbnTextBox.Text = "";
            PriceTextBox.Text = "";
            QuantityTextBox.Text = "";
            SubtotalTextBox.Text = "0";
            TaxTextBox.Text = "0";
            TotalTextBox.Text = "0";
            subtotal = 0;
            Lines.Clear();
            DataList.Rows.Clear();
            comboBox1.SelectedIndex = 0;
            CustomerComboBox.SelectedIndex = 0; 
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^0{2,}").IsMatch(QuantityTextBox.Text))
            {
                QuantityTextBox.Text = QuantityTextBox.Text.Replace(QuantityTextBox.Text, "0");
            }
        }

        private void RecordOrder(Order order)
        {
            // Customer id , order id, sub-total, Tax, Total, and Order Date
            string queryStr = "SET IDENTITY_INSERT Orders OFF; insert into Orders(CustomerID, SubTotal, Tax, Total, OrderDate) Values(@customerID, @subtotal, @tax, @total, @orderDate); SELECT MAX(OrderID) FROM Orders";
            scmd = new SqlCommand(queryStr, connection);
            connection.Open();
            scmd.Parameters.AddWithValue("@customerID", order.CustomerID);
            scmd.Parameters.AddWithValue("@subTotal", order.SubTotal);
            scmd.Parameters.AddWithValue("@tax", order.Tax);
            scmd.Parameters.AddWithValue("@total", order.Total);
            scmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
            orderID = (int)scmd.ExecuteScalar();
            connection.Close();
        }

        private void RecordOrderDetails(List<OrderDetails> odl)
        {
            // Customer id, order id, sub-total, Tax, Total, and Order Date  
            string queryStr = "insert into OrderDetails(OrderID, BookID, Quantity, LinesTotal) Values(@orderID, @bookID, @quantity, @linesTotal)";
            odl.ForEach(order =>
            {
                scmd = new SqlCommand(queryStr, connection);
                scmd.Parameters.AddWithValue("@orderID", orderID);
                scmd.Parameters.AddWithValue("@bookID", order.BookID);
                scmd.Parameters.AddWithValue("@quantity", order.Quantity);
                scmd.Parameters.AddWithValue("@linesTotal", order.LinesTotal);
                connection.Open();
                scmd.ExecuteNonQuery();
                connection.Close();
            });
        }
    }
}
