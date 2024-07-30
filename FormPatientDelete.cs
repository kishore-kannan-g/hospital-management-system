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

namespace HospitalManagement
{
    public partial class FormPatientDelete : Form
    {
        public FormPatientDelete()
        {
            InitializeComponent();
        }

        private void buttongetPatient_Click(object sender, EventArgs e)
        {
            string doc_id = textBoxgetp_id.Text;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                con.Open();
                string query = "select * from PatientInfo where Id = '" + doc_id + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    textBoxPdelname.Text = rdr["NAME"].ToString();
                    textBoxPdelnumber.Text = rdr["CONTACT_NUMBER"].ToString();
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

        private void buttonPatientDelete_Click(object sender, EventArgs e)
        {
            string doc_id = textBoxgetp_id.Text;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                con.Open();
                string query = "delete from PatientInfo where Id = '" + doc_id + "' ";
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

        private void FormPatientDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
