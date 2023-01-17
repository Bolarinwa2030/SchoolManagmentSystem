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
    public partial class rEPORT : Form
    {
        public rEPORT()
        {
            InitializeComponent();
        }

        private void rEPORT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NewDataSet1.NewReg' table. You can move, or remove it, as needed.
            this.NewRegTableAdapter.Fill(this.NewDataSet1.NewReg);

            this.reportViewer1.RefreshReport();
        }
    }
}
