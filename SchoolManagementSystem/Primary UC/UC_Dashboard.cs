using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Primary_UC
{
    public partial class UC_Dashboard : UserControl
    {
        Int64 count;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BOLARINWA-PC\\BGSKILLZ;Initial Catalog=NSchool;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max(ID)from NewReg";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Int64 abc = Convert.ToInt64(ds.Tables[0].Rows[0][0]);
            guna2TextBox1.Text = (abc + 1).ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
           
        }
    }
}
