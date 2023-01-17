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
    public partial class RemoveStudent : UserControl
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BOLARINWA-PC\\BGSKILLZ;Initial Catalog=NSchool;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewReg";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);

            guna2DataGridView1.DataSource = Ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != null)
            {

            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BOLARINWA-PC\\BGSKILLZ;Initial Catalog=NSchool;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewReg where ID= " + guna2TextBox1.Text + "";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            Da.Fill(ds);

            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            RemoveStudent_Load(this, null);
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your Data", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=BOLARINWA-PC\\BGSKILLZ;Initial Catalog=NSchool;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewReg where ID = " + guna2TextBox1.Text + "";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                Da.Fill(ds);
                MessageBox.Show("Deletion Sucessful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RemoveStudent_Load(this, null);
            }
        }
    }
    }
      

