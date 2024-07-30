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
    public partial class FormAppointmentDel : Form
    {
        public FormAppointmentDel()
        {
            InitializeComponent();
        }

        private void FormAppointmentDel_Load(object sender, EventArgs e)
        {

        }

        private void buttongetApp_Click(object sender, EventArgs e)
        {
            string app_id = textBoxgetApp_id.Text;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                con.Open();
                string query = "select * from Appointment where APPOINTMENT_NO = '" + app_id + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    labelPname.Text = rdr["PATIENT_NAME"].ToString();
                    labelDname.Text = rdr["DOCTOR_NAME"].ToString();
                    labelAdate.Text = rdr["DATE"].ToString();
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

        private void buttonAppdel_Click(object sender, EventArgs e)
        {
            string app_id = textBoxgetApp_id.Text;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                con.Open();
                string query = "delete from Appointment where APPOINTMENT_NO = '" + app_id + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Deleted");
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

        private void textBoxgetApp_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
