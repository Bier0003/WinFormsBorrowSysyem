
using Npgsql;
using System.Data;


namespace WinFormsBorrowSystem
{
    public partial class Login : Form
    {
        public bool logined = false;
        public MainPage myParentForm { get; set; }
        public Login()
        {
            InitializeComponent();
        }


        private void RegisterBT(object sender, EventArgs e)
        {
            //this.Close();
            //ทำไงก็ได้ให้ mainpage รู้ว่าเรากำลังจะไปหน้า register
           // this.logined = false;
            RegisterForm r = new RegisterForm();
            //r.MdiParent = this;
            r.MaximizeBox = true;
            r.myParentForm = this;
            r.Show();

        }

        private void LoginBT(object sender, EventArgs e)
        {


            string username = textBox1.Text;
            string password = textBox2.Text;

            // Define your connection string
            //string connectionString = "Host=localhost;Username=admin;Password=admin;Database=BorrowSystem";

            // Use a parameterized query to avoid SQL injection
            string query = "SELECT COUNT(*) as counts FROM students WHERE username = @username AND password = mk(@password)";

            ConnectDB conDb = new ConnectDB();
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            DataTable data = conDb.Query(cmd);

            if ((int)data.Rows[0]["counts"] > 0)
            {
                this.logined = true;
                this.Close();
                this.myParentForm.passLogin();
                return;
            }
            else
            {
                MessageBox.Show("User and password is incorrect");

            }


        }



    }
}

////sende to mainpage
//private var Log = new MainPage();
//Log.Show();





