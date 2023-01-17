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

namespace SchoolManagementSystem.Primary_UC
{
    public partial class UC_PrimaryFees : UserControl
    {
        public UC_PrimaryFees()
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

               
                    MemoryStream ms = new MemoryStream((byte[])(Ds.Tables[0].Rows[0]["photo"]));
                    pictureBox2.Image = new Bitmap(ms);
                    //ictureBox2.Image = null;
                
                    

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
                pictureBox2.Image = null;

            }
        }
        public void clearAll()
        {
            labelAdmissionNumber.Text = "- - - - - - - ";
            labelSurname.Text = "- - - - - - - ";
            labelFirstName.Text = "- - - - - - - ";
            labelLastName.Text = "- - - - - - - ";
            labelGender.Text = "- - - - - - - ";
            txtAmountPaid.Clear();
            txtDateofPayment.ResetText();
            txtTypeofPayment.ResetText();
            guna2TextBox1.Clear();
            pictureBox2.ResetText();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BOLARINWA-PC\\BGSKILLZ;Initial Catalog=NSchool;Integrated Security=True"; 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Fees (DateofPayment, TypeofPayment,Amount) values ('" + txtDateofPayment.Text + "', '" + txtTypeofPayment.Text + "', '" + txtAmountPaid.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Payment made Succesfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FeeForm me = new FeeForm();
            me.Show();
            UC_PrimaryFees_Load(this, null);
            clearAll();
        }

        private void UC_PrimaryFees_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BOLARINWA-PC\\BGSKILLZ;Initial Catalog=NSchool;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewReg.AdmissionNo as Admission_No, NewReg.surname as Surname, NewReg.firstname as First_Name, NewReg.lastname as Last_Name, NewReg.gender as Gender, Fees.Amount as Amount_Paid from NewReg inner join Fees on NewReg.ID =Fees.ID";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);

            guna2DataGridView1.DataSource = Ds.Tables[0];
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
               
            }
        }
    }