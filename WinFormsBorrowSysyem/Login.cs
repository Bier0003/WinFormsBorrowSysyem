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
            var Log = new MainPage();
            Log.Show();
        }

        private void UserText(object sender, EventArgs e)
        {

        }

        private void PasswordText(object sender, EventArgs e)
        {

        }
    }
}
