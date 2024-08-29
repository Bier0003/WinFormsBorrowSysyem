using Npgsql;
using System.Data.SqlClient;
using WinFormsBorrowSystem;

namespace WinFormsBorrowSysyem
{
    public partial class EquipmentForm : Form
    {
        public EquipmentForm()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Define your connection string
            string connectionString = "Host=localhost;Username=admin;Password=admin;Database=BorrowSystem";

            // Use a parameterized query to avoid SQL injection
            string query = "INSERT INTO students (username,password) VALUES (@username,mk(@password))";


            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);

                        // Execute the query                        
                        int affected = cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void FillCombobox1()
        {

            // Define your connection string
            //string connectionString = "Host=localhost;Username=admin;Password=admin;Database=BorrowSystem";

            // Use a parameterized query to avoid SQL injection
            string query = "SELECT Brand/Model  FROM  Computer";

            ConnectDB conDb = new ConnectDB();
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            SqlDataReader myreader

                try
            {
                conDb.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                }

                //DataTable data = conDb.Query(cmd);





            }
}
    }
}
