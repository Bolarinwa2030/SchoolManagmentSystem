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
    public partial class Uc_TeacherRegistration : UserControl
    {
        public Uc_TeacherRegistration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String surname = txtSurname.Text;
            String othername = txtOtherName.Text;
            String gender = "";
            bool IsChecked = txtMale.Checked;
            if (IsChecked)
            {
                gender = txtMale.Text;
            }
            else
            {
                gender = txtFemale.Text;
            }
            String dob = txtDOB.Text;
            Int64 phone = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String qualification = txtQualification.Text;
            String yearofemploy = txtYearofEmploy.Text;
            String areaofspec = txtAreaofSpec.Text;
            String taddress = txtpaddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BOLARINWA-PC\\BGSKILLZ;Initial Catalog=NSchool;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Teacher1 (surname, othername, gender, dob, phone, email, qualification, yearofemploy, areaofspec, taddress) values('" + surname + "', '" + othername + "', '" + gender + "', '" + dob + "', '" + phone + "', '" + email + "', '" + qualification + "', '" +yearofemploy + "', '" + areaofspec + "','" + taddress + "') ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            MessageBox.Show("Data Saved Successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Uc_TeacherRegistration_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BOLARINWA-PC\\BGSKILLZ;Initial Catalog=NSchool;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Teacher1";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);

            guna2DataGridView1.DataSource = Ds.Tables[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSurname.Clear();
            txtOtherName.Clear();
            txtMale.Checked = false;
            txtFemale.Checked = false;
            txtDOB.ResetText();
            txtEmail.Clear();
            txtMobile.Clear();
            txtQualification.ResetText();
            txtYearofEmploy.ResetText();
            txtpaddress.Clear();
            txtAreaofSpec.Clear();
           
        }
    }
}
