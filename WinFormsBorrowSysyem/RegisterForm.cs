using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsBorrowSystem
{
    public partial class RegisterForm : Form
    {
        internal Login myParentForm;

        //public chilePage RegisterFom  { get; set; }


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegBT(object sender, EventArgs e)
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

        private void idstudentBox(object sender, EventArgs e)
        {

        }

        private void fname(object sender, EventArgs e)
        {

        }

        private void lname(object sender, EventArgs e)
        {

        }

        private void userBT(object sender, EventArgs e)
        {

        }

        private void pwBT(object sender, EventArgs e)
        {

        }

        private void picture(object sender, EventArgs e)
        {

        }
    }
}
