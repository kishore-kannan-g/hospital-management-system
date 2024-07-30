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
    public partial class FormDoctor2 : Form
    {
        public FormDoctor2()
        {
            InitializeComponent();
        }

        private void buttonDadd_Click(object sender, EventArgs e)
        {
            string dname, dgender, dspecial, dyoe,dtime;
            double dnumber;
            int dage;
            RadioButton rb = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            dgender = rb.Text;
            dname = textBoxDname.Text;
            dspecial = textBoxDspecial.Text;
            dyoe = comboBox1.SelectedItem.ToString();
            dnumber = Convert.ToDouble(textBoxDnumber.Text);
            dage = Convert.ToInt32(textBoxDage.Text);
            dtime = comboBox2.SelectedItem.ToString();

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                string query = "INSERT INTO DoctorInfo(NAME,GENDER,AGE,CONTACT_NUMBER,SPECIALIZATION,YRS_OF_EXPERIENCE,WORKING_HRS) VALUES('" + dname + "','" + dgender + "','" + dage + "','" + dnumber + "','" + dspecial + "','" + dyoe + "','"+dtime+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added");

                string query2 = "Select Id from DoctorInfo where NAME = '" + dname + "' ";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.ExecuteNonQuery();
                SqlDataReader reader = cmd2.ExecuteReader();
                if(reader.Read())
                {
                    MessageBox.Show("Your Id = " + reader["Id"].ToString());
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry error occurred");
            }
            finally
            {
                con.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDoctor2_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDname_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
