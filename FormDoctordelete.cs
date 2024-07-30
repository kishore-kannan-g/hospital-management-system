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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagement
{
    public partial class FormDoctordelete : Form
    {
        public FormDoctordelete()
        {
            InitializeComponent();
        }

        private void buttongetDoctor_Click(object sender, EventArgs e)
        {
            string doc_id = textBoxgetd_id.Text;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                con.Open();
                string query = "select * from DoctorInfo where Id = '" + doc_id + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    textBoxDdelname.Text = rdr["NAME"].ToString();
                    textBoxDdelnumber.Text = rdr["CONTACT_NUMBER"].ToString();                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonDoctorDelete_Click(object sender, EventArgs e)
        {
            string doc_id = textBoxgetd_id.Text;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                con.Open();
                string query = "delete from DoctorInfo where Id = '" + doc_id + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile Deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
