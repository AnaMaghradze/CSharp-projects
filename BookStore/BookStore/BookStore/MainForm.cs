using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace BookStore
{
    public partial class MainForm : Form
    {
        private SqlConnection connection = new SqlConnection(DataHandler.ConnectionString);

        public MainForm()
        {
            InitializeComponent();
        }

        private void ManageCustomersButton_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void ManageBooksButton_Click(object sender, EventArgs e)
        {
            BooksForm bookStoreForm = new BooksForm();
            bookStoreForm.Show();
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            BookStoreForm bookStoreForm = new BookStoreForm();
            bookStoreForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var fileName = File.ReadAllText("Data/query.sql");
            var queries = fileName.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
            SqlCommand scmd = new SqlCommand("query", connection);
            connection.Open();
            foreach (var query in queries)
            {
                scmd.CommandText = query;
                scmd.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
