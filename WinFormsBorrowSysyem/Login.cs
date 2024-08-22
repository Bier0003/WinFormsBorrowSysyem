
using Npgsql;

namespace WinFormsBorrowSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void RegisterBT(object sender, EventArgs e)
        {
            var Reg = new RegisterForm();
            Reg.Show();

        }

        private void LoginBT(object sender, EventArgs e)
        {





            string username = textBox1.Text;
            string password = textBox2.Text;

            // Define your connection string
            string connectionString = "Host=localhost;Username=admin;Password=admin;Database=BorrowSystem";

            // Use a parameterized query to avoid SQL injection
            string query = "SELECT COUNT(*) FROM students WHERE username = @username AND password = @password";

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
                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            // Login successful
                            MessageBox.Show("Login Successful!");

                            // Proceed to next page
                            var log = new MainPage();
                            log.Show();

                            // Close the login window
                            this.Close();
                        }
                        else
                        {
                            // Login failed
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

    ////sende to mainpage
    //private var Log = new MainPage();
    //Log.Show();





