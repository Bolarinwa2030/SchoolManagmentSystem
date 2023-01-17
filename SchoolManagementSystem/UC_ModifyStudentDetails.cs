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
using System.IO;

namespace SchoolManagementSystem
{
    public partial class UC_ModifyStudentDetails : UserControl
    {
        public UC_ModifyStudentDetails()
        {
            InitializeComponent();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BOLARINWA-PC\\BGSKILLZ;Initial Catalog=NSchool;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewReg where ID = " + guna2TextBox1.Text + "";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            if (Ds.Tables[0].Rows.Count != 0)
            {

                labelAdmissionNumber.Text = Ds.Tables[0].Rows[0][13].ToString();
                labelSurname.Text = Ds.Tables[0].Rows[0][1].ToString();
                labelFirstName.Text = Ds.Tables[0].Rows[0][2].ToString();
                labelLastName.Text = Ds.Tables[0].Rows[0][3].ToString();
                labelGender.Text = Ds.Tables[0].Rows[0][4].ToString();
                labelDob.Text = Ds.Tables[0].Rows[0][5].ToString();
                labelCity.Text = Ds.Tables[0].Rows[0][6].ToString();
                labelReligion.Text = Ds.Tables[0].Rows[0][8].ToString();
                labelStateofOrigin.Text = Ds.Tables[0].Rows[0][11].ToString();
                labelAddress.Text = Ds.Tables[0].Rows[0][12].ToString();
                labelName.Text = Ds.Tables[0].Rows[0][14].ToString();
                labelRelation.Text = Ds.Tables[0].Rows[0][15].ToString();
                labelPaddress.Text = Ds.Tables[0].Rows[0][17].ToString();
                labelOccup.Text = Ds.Tables[0].Rows[0][16].ToString();
                labelPhoneNo.Text = Ds.Tables[0].Rows[0][18].ToString();
                labelAdmissionDate.Text = Ds.Tables[0].Rows[0][9].ToString();

                MemoryStream ms = new MemoryStream((byte[])(Ds.Tables[0].Rows[0]["photo"]));
                pictureBox2.Image = new Bitmap(ms);
                //else
                //{
                //    MemoryStream mstream = new MemoryStream();
                //    pictureBox2.Image = System.Drawing.Image.FromStream(mstream);
                //}
                

            }
            else
            {
                MessageBox.Show("Nor Record Found", "No Macth", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelAdmissionNumber.Text = "- - - - - - - ";
                labelSurname.Text = "- - - - - - - ";
                labelFirstName.Text = "- - - - - - - ";
                labelLastName.Text = "- - - - - - - ";
                labelGender.Text = "- - - - - - - ";
                labelDob.Text = "- - - - - - - ";
                labelCity.Text = "- - - - - - - ";
                labelReligion.Text = "- - - - - - - ";
                labelStateofOrigin.Text = "- - - - - - - ";
                labelAddress.Text = "- - - - - - - ";
                labelName.Text = "- - - - - - - ";
                labelRelation.Text = "- - - - - - - ";
                labelPaddress.Text = "- - - - - - - ";
                labelOccup.Text = "- - - - - - - ";
                labelPhoneNo.Text = "- - - - - - - ";
            }
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
            }
            }
    }
}