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
    public partial class SplashScreenNew : Form
    {
        public SplashScreenNew()
        {
            InitializeComponent();
            bunifuCircleProgressbar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            bunifuCircleProgressbar1.Value = 1;
            bunifuCircleProgressbar1.ResetText();
            if (bunifuCircleProgressbar1.Value==100)
            {
                Form1 me = new Form1();
                me.Show();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
