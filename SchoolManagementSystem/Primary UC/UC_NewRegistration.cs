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
    public partial class UC_NewRegistration : UserControl
    {
       
        public UC_NewRegistration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {  
            
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.txtPicturePath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);

            String surname = txtSurname.Text;
            String firstname = txtFirstName.Text;
            String lastname = txtLastName.Text;
            String gender = txtGender.Text;
            String dob = txtDOB.Text;
            String city = txtCity.Text;
            String classadmit = txtClassAdmit.Text;
            String religion = txtReligion.Text;
            String DateofAdmin = txtAdmissionDate.Text;
            String placeofbirth = txtPlaceofBirth.Text;
            String stateofOrigin = txtStateofOrigin.Text;
            String studaddress = txtAddress.Text;
            String AdmissionNo = txtAdmissionNumber.Text;
            String pname = txtpname.Text;
            String relation = txtrelation.Text;
            String occupation = txtOccupation.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String paddress = txtpaddress.Text;

            

            SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=BOLARINWA-PC\\BGSKILLZ;Initial Catalog=NSchool;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into NewReg (surname, firstname, lastname, gender, dob, city, classadmit, religion, DateofAdmin, placeofbirth, stateofOrigin, studaddress, AdmissionNo, pname, relation, occupation, mobile, paddress, photo) values('" + surname + "', '"+firstname+"', '"+lastname+"', '"+gender+"', '"+dob+"', '"+city+"', '"+classadmit+"', '"+religion+"', '"+DateofAdmin+"', '"+placeofbirth+"', '"+stateofOrigin+"', '"+studaddress+"', '"+AdmissionNo+"','"+pname+"', '"+relation+"', '"+occupation+"', '"+mobile+"', '"+paddress+"',@photo)";
            cmd.Parameters.Add(new SqlParameter("@photo", imageBt));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
            
               da.Fill(ds);
                con.Close();
            MessageBox.Show("Data Saved Successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg;  *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               
                string picloc = dlg.FileName.ToString();
                txtPicturePath.Text = picloc;
                pictureBox2.ImageLocation = picloc;
            }
        }

        private void UC_NewRegistration_Load(object sender, EventArgs e)
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
            label27.Text = (abc + 1).ToString();
        }

        private void txtguard2name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void txtguard2relat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSurname.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtGender.ResetText();
            txtDOB.ResetText();
            txtCity.Clear();
            txtClassAdmit.ResetText();
            txtReligion.ResetText();
            txtAdmissionDate.ResetText();
            txtPlaceofBirth.Clear();
            txtStateofOrigin.ResetText();
            txtAddress.Clear();
           txtAdmissionNumber.Clear();
            txtpname.Clear();
            txtrelation.ResetText();
             txtOccupation.Clear();
            txtMobile.Clear();
            txtpaddress.Clear();
            pictureBox2.ResetText();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rEPORT me = new rEPORT();
            me.Show();
          
        }
    }
}
