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
    public partial class FeeForm : Form
    {
        public FeeForm()
        {
            InitializeComponent();
        }

        private void FeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NewDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.NewDataSet1.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
