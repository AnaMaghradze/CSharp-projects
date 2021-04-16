using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Ana Maghradze
/// red ID: 82335646
/// </summary>
namespace BookStore
{
    public class DataHandler
    {
        public static string ConnectionString { get; set; } = @"Data Source=desktop-3en6tgv\sqlexpress;Initial Catalog=BookStore;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(ConnectionString);
        private SqlDataAdapter adapter;

        public DataHandler() {}

        // fills combobox with data from sql databaze
        public void FillComboboxWithData(string queryString, ComboBox combobox, string combobox_fistMember, string combobox_valueMember, string combobox_displayMember)
        {
            DataRow dr;
            DataTable dt = new DataTable();
            connection.Open();
            adapter = new SqlDataAdapter(queryString, connection);
            adapter.Fill(dt);
            combobox.DataSource = dt;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { combobox_fistMember };
            dt.Rows.InsertAt(dr, 0);
            combobox.ValueMember = combobox_valueMember;
            combobox.DisplayMember = combobox_displayMember;
            combobox.DataSource = dt;
            connection.Close();
        }
    }
}
