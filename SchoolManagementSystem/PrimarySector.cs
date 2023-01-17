using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class PrimarySector : Form
    {
        
        public PrimarySector()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void PrimarySector_Load(object sender, EventArgs e)
        {
            timer1.Start();
            uC_Dashboard1.Visible = false;
            uC_NewRegistration1.Visible = false;
            uc_TeacherRegistration1.Visible = false;
            uC_ModifyStudentDetails1.Visible = false;
            uC_PrimaryFees1.Visible = false;
            removeStudent1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 me = new Form1();
            me.Show();
            this.Close();
          
        }

        private void btnNewRegistration_Click(object sender, EventArgs e)
        {
            uC_NewRegistration1.Visible = true;
            uC_NewRegistration1.BringToFront();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTeacherRegistration_Click(object sender, EventArgs e)
        {
            uc_TeacherRegistration1.Visible = true;
            uc_TeacherRegistration1.BringToFront();

        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            uC_ModifyStudentDetails1.Visible = true;
            uC_ModifyStudentDetails1.BringToFront();
        }

        private void btnSchoolFees_Click(object sender, EventArgs e)
        {
            uC_PrimaryFees1.Visible = true;
            uC_PrimaryFees1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeStudent1.Visible = true;
            removeStudent1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }
    }
}
