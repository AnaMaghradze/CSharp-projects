using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/// <summary>
/// Ana Maghradze
/// red ID: 82335646
/// </summary>
namespace BookStore
{
    public partial class CustomerForm : Form
    {
        private SqlConnection connection = new SqlConnection(DataHandler.ConnectionString);
        private SqlDataAdapter adapter;
        private SqlCommand scmd;
        private List<Customer> CustomerList = new List<Customer>();        
        bool addNewCustomerMode = false; // for creatig new customer
        bool updateCustomerMode = false; // for updating existing cusomer  
        DataHandler dh = new DataHandler();
        int customerID;        

        public CustomerForm()
        {
            InitializeComponent();
            DisplayCustomers(); // load data from txt to combobox
            ResetAll();
            EnableTextFields(false);            
            SaveButton.Enabled = false;
        }

        private void DisplayCustomers()
        {
            string queryStr = "select (FirstName + ' ' + LastName) as FullName, Email, Phone, Address, City, Zip FROM Customers";
            dh.FillComboboxWithData(queryStr, CustomerComboBox, "-- Edit an Existing Customer --", "FullName", "FullName");
        }

        // combobox value (index) changed
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Customers", connection);
            adapter.Fill(dt);
            int index = CustomerComboBox.SelectedIndex - 1;
            if (index >= 0)
            {
                FirstNameTextBox.Text = dt.Rows[index]["FirstName"].ToString();
                LastNameTextBox.Text = dt.Rows[index]["LastName"].ToString();
                EmailTextBox.Text = dt.Rows[index]["Email"].ToString();
                PhoneTextBox.Text = dt.Rows[index]["Phone"].ToString();
                AddressTextBox.Text = dt.Rows[index]["Address"].ToString();
                StateTextBox.Text = dt.Rows[index]["State"].ToString();
                CityTextBox.Text = dt.Rows[index]["City"].ToString();
                ZipTextBox.Text = dt.Rows[index]["Zip"].ToString();
                EnableTextFields(true);                

                // get current customer's ID and save in customerID
                string cmdText = "select ID from Customers where FirstName = @firstName and LastName = @lastName and Email = @email and Phone = @phone and Address = @address and City = @city and State = @state and Zip = @zip";
                scmd = new SqlCommand(cmdText, connection);
                scmd.Parameters.AddWithValue("@firstName", FirstNameTextBox.Text);
                scmd.Parameters.AddWithValue("@lastName", LastNameTextBox.Text);
                scmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
                scmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                scmd.Parameters.AddWithValue("@address", AddressTextBox.Text);
                scmd.Parameters.AddWithValue("@city", CityTextBox.Text);
                scmd.Parameters.AddWithValue("@state", StateTextBox.Text);
                scmd.Parameters.AddWithValue("@zip", ZipTextBox.Text);
                connection.Open();
                SqlDataReader reader = scmd.ExecuteReader();
                if (reader.Read())
                {
                    customerID = Convert.ToInt32(reader["ID"]);
                }
                connection.Close();
                updateCustomerMode = true;
                addNewCustomerMode = false;
                SaveButton.Enabled = true;
            }
            else
            {
                ResetAll();
                EnableTextFields(false);
                updateCustomerMode = false;
                SaveButton.Enabled = false;
            }
        }

        // New Customer button clicked
        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            // if text fields are filled, show messagebox
            if (FirstNameTextBox.Text != "" || LastNameTextBox.Text != "" ||
               EmailTextBox.Text != "" || PhoneTextBox.Text != "" ||
               AddressTextBox.Text != "" || CityTextBox.Text != "" ||
               StateTextBox.Text != "" || ZipTextBox.Text != "")
            {
                DialogResult response = MessageBox.Show("Are you sure you want to discard all the changes?", "Discard Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (response == DialogResult.Yes)
                {
                    ResetAll();
                    FirstNameTextBox.Focus();
                    SaveButton.Enabled = true;
                    CustomerComboBox.Enabled = false;
                    addNewCustomerMode = true;
                    updateCustomerMode = false;
                }
            }
            else
            {
                ResetAll();
                FirstNameTextBox.Focus();
                SaveButton.Enabled = true;
                CustomerComboBox.Enabled = false;
                addNewCustomerMode = true;
                updateCustomerMode = false;
            }
            EnableTextFields(true);
            CustomerCancelButton.Enabled = true;            
        }

        // save button clicked
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == "" || FirstNameTextBox.ForeColor == Color.Red)
            {
                MessageBox.Show("Make sure you filled out <First Name> field and entered only letters (a-z, A-Z)", "Invalid Input Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTextBox.Focus();
            }
            else if (LastNameTextBox.Text == "" || LastNameTextBox.ForeColor == Color.Red)
            {
                MessageBox.Show("Make sure you filled out <Last Name> field and entered only letters (a-z, A-Z)", "Invalid Input Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTextBox.Focus();
            }
            else if (PhoneTextBox.Text == "" || PhoneTextBox.ForeColor == Color.Red)
            {
                MessageBox.Show("Make sure you filled out <Phone Number> field and input is in correct format (XXXXXXXXXX or XXX XXX XXXX or XXX-XXX-XXXX)", "Invalid Input Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneTextBox.Focus();
            }
            else if (EmailTextBox.Text == "" || EmailTextBox.ForeColor == Color.Red)
            {
                MessageBox.Show("Make sure you filled out <Email> field and provided valid Email", "Invalid Input Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailTextBox.Focus();
            }
            else if (CityTextBox.Text == "" || CityTextBox.ForeColor == Color.Red)
            {
                MessageBox.Show("Make sure you filled out <City> field and provided valid input", "Invalid Input Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CityTextBox.Focus();
            }
            else if (StateTextBox.Text == "" || StateTextBox.ForeColor == Color.Red)
            {
                MessageBox.Show("Make sure you filled out <State> field and provided valid input", "Invalid Input Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StateTextBox.Focus();
            }
            else if (ZipTextBox.Text == "" || ZipTextBox.ForeColor == Color.Red)
            {
                MessageBox.Show("Make sure you filled out <Zip> field and input is in valid format (XXXXX)", "Invalid Input Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ZipTextBox.Focus();
            }
            else if (AddressTextBox.Text == "" || AddressTextBox.ForeColor == Color.Red)
            {
                MessageBox.Show("Make sure you filled out <Address> field and provided valid input", "Invalid Input Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddressTextBox.Focus();
            }
            else
            {
                string cmdText = "select count(*) from Customers where FirstName = @firstName and LastName = @lastName and Email = @email and Phone = @phone and Address = @address and City = @city and State = @state and Zip = @zip";
                scmd = new SqlCommand(cmdText, connection);
                connection.Open();
                scmd.Parameters.AddWithValue("@firstName", FirstNameTextBox.Text);
                scmd.Parameters.AddWithValue("@lastName", LastNameTextBox.Text);
                scmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
                scmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                scmd.Parameters.AddWithValue("@address", AddressTextBox.Text);
                scmd.Parameters.AddWithValue("@city", CityTextBox.Text);
                scmd.Parameters.AddWithValue("@state", StateTextBox.Text);
                scmd.Parameters.AddWithValue("@zip", ZipTextBox.Text);
                int exists = (int)scmd.ExecuteScalar(); // check if entered isnb is unique
                connection.Close();
                // if user clicks new customer button, add new customer mode is on
                if (addNewCustomerMode)
                {
                    if (exists > 0) {
                        MessageBox.Show("Customer Already Exists", "Addition of existing Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult save = MessageBox.Show("Do you want to save the Customer?", "Add New Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (save == DialogResult.Yes)
                        {
                            scmd = new SqlCommand("SET IDENTITY_INSERT Customers OFF; insert into Customers(FirstName, LastName, Email, Phone, Address, City, State, Zip) Values(@firstName, @lastName, @email, @phone, @address, @city, @state, @zip)", connection);
                            connection.Open();
                            scmd.Parameters.AddWithValue("@firstName", FirstNameTextBox.Text);
                            scmd.Parameters.AddWithValue("@lastName", LastNameTextBox.Text);
                            scmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
                            scmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                            scmd.Parameters.AddWithValue("@address", AddressTextBox.Text);
                            scmd.Parameters.AddWithValue("@state", CityTextBox.Text);
                            scmd.Parameters.AddWithValue("@city", CityTextBox.Text);
                            scmd.Parameters.AddWithValue("@zip", ZipTextBox.Text);
                            scmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("The Customer Was Added Successfully.");
                            DisplayCustomers(); // refresh combobox values
                            ResetAll();
                            CustomerComboBox.Enabled = true;
                        }
                    }
                }
                // if user chooses customer from combobox, update customer mode is on                
                if (updateCustomerMode)
                {
                    if (exists > 0)
                    {
                        MessageBox.Show("You haven't modified anything.", "Nothing to update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult save = MessageBox.Show("Do you want to update the Customer?", "Update Existing Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (save == DialogResult.Yes)
                        {
                            cmdText = "update Customers set FirstName = @firstName, LastName = @lastName, Email = @email, Phone = @phone, Address = @address, City = @city, State = @state, Zip = @zip where ID = @customerID";
                            scmd = new SqlCommand(cmdText, connection);
                            connection.Open();
                            scmd.Parameters.AddWithValue("@customerID", customerID);
                            scmd.Parameters.AddWithValue("@firstName", FirstNameTextBox.Text);
                            scmd.Parameters.AddWithValue("@lastName", LastNameTextBox.Text);
                            scmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
                            scmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                            scmd.Parameters.AddWithValue("@address", AddressTextBox.Text);
                            scmd.Parameters.AddWithValue("@city", CityTextBox.Text);
                            scmd.Parameters.AddWithValue("@state", StateTextBox.Text);
                            scmd.Parameters.AddWithValue("@zip", ZipTextBox.Text);
                            scmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("The Customer Was Updated Successfully.");
                            DisplayCustomers(); // refresh combobox values
                            ResetAll();
                        }
                    }                    
                }
            }
        }        

        // if back button is clicked, close customer form
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text != "" || LastNameTextBox.Text != "" ||
               EmailTextBox.Text != "" || PhoneTextBox.Text != "" ||
               AddressTextBox.Text != "" || CityTextBox.Text != "" ||
               StateTextBox.Text != "" || ZipTextBox.Text != "")
            {
                DialogResult response = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (response == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        // if Cancel button is clicked, reset the form
        private void CustomerCancelButton_Click(object sender, EventArgs e)
        {
            // if text fields are filled, show messagebox
            if (FirstNameTextBox.Text != "" || LastNameTextBox.Text != "" ||
               EmailTextBox.Text != "" || PhoneTextBox.Text != "" ||
               AddressTextBox.Text != "" || CityTextBox.Text != "" ||
               StateTextBox.Text != "" || ZipTextBox.Text != "")
            {
                DialogResult response = MessageBox.Show("Are you sure you want to discard all changes?", "Return Back", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (response == DialogResult.Yes)
                {
                    ResetAll();
                    EnableTextFields(false);
                    SaveButton.Enabled = false;
                    CustomerComboBox.Enabled = true;
                }
            }
            else
            {
                ResetAll();
                EnableTextFields(false);
                SaveButton.Enabled = false;
                CustomerComboBox.Enabled = true;
            }
        }
         
        //validate first name
        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[A-Za-z]+$")).IsMatch(FirstNameTextBox.Text))
            {
                FirstNameTextBox.ForeColor = Color.Red;
            }
            else
            {
                FirstNameTextBox.ForeColor = Color.Black;
            }
        }
        // validate last name
        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[A-Za-z]+$")).IsMatch(LastNameTextBox.Text))
            {
                LastNameTextBox.ForeColor = Color.Red;
            }
            else
            {
                LastNameTextBox.ForeColor = Color.Black;
            }
        }
        // validate email
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")).IsMatch(EmailTextBox.Text))
            {
                EmailTextBox.ForeColor = Color.Red;
            }
            else
            {
                EmailTextBox.ForeColor = Color.Black;
            }
        }
        // validate phone number
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$")).IsMatch(PhoneTextBox.Text))
            {
                PhoneTextBox.ForeColor = Color.Red;
            }
            else
            {
                PhoneTextBox.ForeColor = Color.Black;
            }
        }
        // validate address
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[A-Za-z][A-Za-z0-9\s]+$")).IsMatch(AddressTextBox.Text))
            {
                AddressTextBox.ForeColor = Color.Red;
            }
            else
            {
                AddressTextBox.ForeColor = Color.Black;
            }
        }
        // validate city
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[A-Za-z\s]+$")).IsMatch(CityTextBox.Text))
            {
                CityTextBox.ForeColor = Color.Red;
            }
            else
            {
                CityTextBox.ForeColor = Color.Black;
            }
        }
        // validate state
        private void StateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[A-Za-z\s]+$")).IsMatch(StateTextBox.Text))
            {
                StateTextBox.ForeColor = Color.Red;
            }
            else
            {
                StateTextBox.ForeColor = Color.Black;
            }
        }
        // validate zip
        private void ZipTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"\d{5}$")).IsMatch(ZipTextBox.Text))
            {
                ZipTextBox.ForeColor = Color.Red;
            }
            else
            {
                ZipTextBox.ForeColor = Color.Black;
            }
        } 
        
        private void EnableTextFields(Boolean option)
        {
            FirstNameTextBox.Enabled = option;
            LastNameTextBox.Enabled = option;
            EmailTextBox.Enabled = option;
            PhoneTextBox.Enabled = option;
            AddressTextBox.Enabled = option;
            CityTextBox.Enabled = option;
            StateTextBox.Enabled = option;
            ZipTextBox.Enabled = option;
        }

        private void ResetAll()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipTextBox.Text = "";
            CustomerComboBox.SelectedIndex = 0;
        }
    }
}
