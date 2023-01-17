using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ////    Thread t = new Thread(new ThreadStart(SplashStart));
            //    t.Start();
            //    Thread.Sleep(5000);
            InitializeComponent();
            //    t.Abort();
            //}
            //public void SplashStart()
            //{
            //    Application.Run(new SplashScreenNew());
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Primary" && txtPassword.Text == "1234")
            {
                PrimarySector me = new PrimarySector();
                me.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password or Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                guna2CheckBox1.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                guna2CheckBox1.Text = "Show Password";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
