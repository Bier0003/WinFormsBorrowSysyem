using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsBorrowSysyem;

namespace WinFormsBorrowSystem
{
    public partial class MainPage : Form
    {
        private bool isLogined = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void SearchBT(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            EquipmentForm eq = new EquipmentForm();
            eq.MdiParent = this;
            eq.MaximizeBox = true;
          //  eq.myParentForm = this;
            eq.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BorrowForm b = new BorrowForm();
            b.MdiParent = this;
            b.MaximizeBox = true;
           // b.myParentForm = this;
            b.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
           // this.Hide();
            Login f = new Login();
            f.MdiParent = this;
            f.MaximizeBox = true;
            f.myParentForm = this;
            f.Show();
        }

        public void passLogin()
        {
            //MessageBox.Show("Login is pass");
            //Show  Form
            //FormEquipment f = new FormEquipment();
            //f.MdiParent = this;
            //f.MaximizeBox = true;
            //f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.isLogined)
            {
               passLogin();
            }
            else
            {
                MessageBox.Show("Can't access this page, Please login first");
            }
        }
    }
}
