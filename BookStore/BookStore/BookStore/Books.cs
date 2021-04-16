using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
/// <summary>
/// Ana Maghradze
/// red ID: 82335646
/// </summary>
namespace BookStore
{
    public partial class BooksForm : Form
    {
        private SqlConnection connection = new SqlConnection(DataHandler.ConnectionString);
        private SqlDataAdapter adapter;
        private SqlCommand scmd;
        bool addNewBookMode = true;
        bool updateBookMode = false;

        DataHandler dh = new DataHandler();

        public BooksForm()
        {
            InitializeComponent();
            DisplayBooks();
            ResetAll();
            EnableTextBoxes(false);
            SaveButton.Enabled = false;
            BookCancelButton.Enabled = false;
        }
        
        // fill combobox with data from Books table
        private void DisplayBooks()
        {
            string queryStr = "select * from Books";
            dh.FillComboboxWithData(queryStr, BooksComboBox,  "-- Edit an Existing Book --", "Title", "Title");
        }

        // user chooses title from the combobox
        private void BooksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Books", connection);
            adapter.Fill(dt);
            int index = BooksComboBox.SelectedIndex - 1;

            if (index >= 0)
            {                
                ISBNTextBox.ReadOnly = true;
                TitleTextBox.Text = dt.Rows[index]["Title"].ToString();
                AuthorTextBox.Text = dt.Rows[index]["Author"].ToString();
                ISBNTextBox.Text = dt.Rows[index]["ISBN"].ToString();
                PriceTextBox.Text = dt.Rows[index]["Price"].ToString();                
                addNewBookMode = false;
                updateBookMode = true;
                EnableTextBoxes(true);
            }
            else
            {
                ResetAll();
                addNewBookMode = true;
                updateBookMode = false;
                EnableTextBoxes(false);
                ISBNTextBox.ReadOnly = false;
                BookCancelButton.Enabled = false;
            }
            SaveButton.Enabled = false;
        }

        // new book button clicked
        private void NewBookButton_Click(object sender, EventArgs e)
        {
            addNewBookMode = true;
            updateBookMode = false;
            ISBNTextBox.ReadOnly = false;
            if (TitleTextBox.Text != "" || AuthorTextBox.Text != "" ||
              ISBNTextBox.Text != "" || PriceTextBox.Text != "")
            {
                DialogResult response = MessageBox.Show("Are you sure you want to discard all the changes?", "Discard Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (response == DialogResult.Yes)
                {
                    ResetAll();
                    TitleTextBox.Focus();
                    BooksComboBox.Enabled = false;
                }
            }
            else
            {
                ResetAll();
                TitleTextBox.Focus();
                BooksComboBox.Enabled = false;           
            }
            EnableTextBoxes(true);
            BookCancelButton.Enabled = true;
        }        

        // cancel button clicked
        private void BookCancelButton_Click(object sender, EventArgs e)
        {
            // if textbox values changed
            if (TitleTextBox.Text != "" || AuthorTextBox.Text != "" ||
              ISBNTextBox.Text != "" || PriceTextBox.Text != "")
            {
                DialogResult response = MessageBox.Show("Are you sure you want to cancel?", "Canceling Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (response == DialogResult.Yes)
                {
                    ResetAll();
                    EnableTextBoxes(false);
                    SaveButton.Enabled = false;
                    BooksComboBox.Enabled = true;                    
                }
            }
            else
            {
                ResetAll();
                EnableTextBoxes(false);
                SaveButton.Enabled = false;
                BooksComboBox.Enabled = true;
            }
        }

        // save button clicked
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.ForeColor != Color.Red && AuthorTextBox.ForeColor != Color.Red &&
               ISBNTextBox.ForeColor != Color.Red && PriceTextBox.ForeColor != Color.Red)
            {
                // adding new book                
                if (addNewBookMode)
                {
                    DialogResult save = MessageBox.Show("Do you want to save the book?", "Add New Book", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(save == DialogResult.Yes)
                    {
                        scmd = new SqlCommand("select count(*) from Books where (ISBN = @isbn)", connection);
                        scmd.Parameters.AddWithValue("@isbn", ISBNTextBox.Text);
                        connection.Open();
                        int exists = (int)scmd.ExecuteScalar(); // check if entered isnb is unique
                        connection.Close();

                        if (exists == 0)
                        {
                            scmd = new SqlCommand("insert into Books(Title, Author, ISBN, Price) Values(@title, @author, @isbn, @price)", connection);
                            connection.Open();
                            scmd.Parameters.AddWithValue("@title", TitleTextBox.Text);
                            scmd.Parameters.AddWithValue("@author", AuthorTextBox.Text);
                            scmd.Parameters.AddWithValue("@isbn", ISBNTextBox.Text);
                            scmd.Parameters.AddWithValue("@price", PriceTextBox.Text);
                            scmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("The Book Was Added Successfully.");
                            DisplayBooks(); // refresh combobox values
                            ResetAll();
                            BooksComboBox.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Provided ISBN code already exists in the database.", "Invalid ISBN Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ISBNTextBox.Focus();
                        }
                    }                    
                }
                // updating existing book                
                if (updateBookMode)
                {
                    DialogResult update = MessageBox.Show("Do you want to update the book?", "Update Existing Book", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (update == DialogResult.Yes)
                    {
                        string cmdText = "UPDATE Books SET Title = @title, Author = @author, Price = @price WHERE ISBN = @isbn";
                        scmd = new SqlCommand(cmdText, connection);
                        connection.Open();
                        scmd.Parameters.AddWithValue("@title", TitleTextBox.Text);
                        scmd.Parameters.AddWithValue("@author", AuthorTextBox.Text);
                        scmd.Parameters.AddWithValue("@isbn", ISBNTextBox.Text);
                        scmd.Parameters.AddWithValue("@price", PriceTextBox.Text);
                        scmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("The Book Was Updated Successfully.");
                        DisplayBooks(); // refresh combobox values
                        ResetAll();
                    }                    
                }               
            }
            else
            {
                MessageBox.Show("Make sure you have provided valid inputs for all the fields", "Invalid Input Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (TitleTextBox.ForeColor == Color.Red)
                {
                    TitleTextBox.Focus();
                }
                if (AuthorTextBox.ForeColor == Color.Red)
                {
                    AuthorTextBox.Focus();
                }
                if(ISBNTextBox.ForeColor == Color.Red)
                {
                    ISBNTextBox.Focus();
                }
                if(PriceTextBox.ForeColor == Color.Red)
                {
                    PriceTextBox.Focus();
                }
            }
        }
                
        // TitleTextBox value changes
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[A-Za-z0-9\s\-_,\.;:()]+$")).IsMatch(TitleTextBox.Text))
            {
                TitleTextBox.ForeColor = Color.Red;
            }
            else
            {
                TitleTextBox.ForeColor = Color.Black;
            }
            CheckTextBoxes();
        }
        // AuthorTextBox value changes
        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[A-Za-z\s\-\.,]+$")).IsMatch(AuthorTextBox.Text))
            {
                AuthorTextBox.ForeColor = Color.Red;
            }
            else
            {
                AuthorTextBox.ForeColor = Color.Black;
            }
            CheckTextBoxes();
        }
        // ISBNTextBox value changes
        private void ISBNTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[A-Za-z0-9]+$")).IsMatch(ISBNTextBox.Text))
            {
                ISBNTextBox.ForeColor = Color.Red;
            }
            else
            {
                ISBNTextBox.ForeColor = Color.Black;
            }
            CheckTextBoxes();
        }
        // PriceTextBox value changes
        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^(\d{1,5}|\d{0,5}\.\d{1,2})$")).IsMatch(PriceTextBox.Text))
            {
                PriceTextBox.ForeColor = Color.Red;
            }
            else if (new Regex(@"^0{2,}").IsMatch(PriceTextBox.Text))
            {
                PriceTextBox.Text = PriceTextBox.Text.Replace(PriceTextBox.Text, "0");
            }
            else
            {
                PriceTextBox.ForeColor = Color.Black;
            }
            CheckTextBoxes();
        }

        // reset all fields to default values
        private void ResetAll()
        {
            BooksComboBox.SelectedIndex = 0;
            TitleTextBox.Text = "";
            AuthorTextBox.Text = "";
            ISBNTextBox.Text = "";
            PriceTextBox.Text = "";
        }

        // enable-disable textboxes
        private void EnableTextBoxes(bool option)
        {
            TitleTextBox.Enabled = option;
            AuthorTextBox.Enabled = option;
            ISBNTextBox.Enabled = option;
            PriceTextBox.Enabled = option;
        }

        // if all of the textboxes have some value (not null), enable save button
        private void CheckTextBoxes()
        {
            if (TitleTextBox.Text != "" && AuthorTextBox.Text != "" &&
               ISBNTextBox.Text != "" && PriceTextBox.Text != "")
            {
                SaveButton.Enabled = true;
            }
            BookCancelButton.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {            
            if (TitleTextBox.Text != "" || AuthorTextBox.Text != "" ||
              ISBNTextBox.Text != "" || PriceTextBox.Text != "")
            {
                DialogResult response = MessageBox.Show("Are you sure you want to discard all changes?", "Discarding Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
    }
}
