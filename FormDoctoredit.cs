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
    public partial class FormDoctoredit : Form
    {
        public FormDoctoredit()
        {
            InitializeComponent();
        }

        private void FormDoctoredit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                if(rdr.Read())
                {
                    textBoxDename.Text = rdr["NAME"].ToString();
                    textBoxDeage.Text = rdr["AGE"].ToString();
                    textBoxDenumber.Text = rdr["CONTACT_NUMBER"].ToString();
                    textBoxDespecial.Text = rdr["SPECIALIZATION"].ToString();
                    string gender = rdr["GENDER"].ToString();
                    if(gender == "Male")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    comboBox2.SelectedItem = rdr["YRS_OF_EXPERIENCE"].ToString();
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

        private void buttoneditDoctor_Click(object sender, EventArgs e)
        {
            string dname, dgender, dspecial, dyoe;
            double dnumber;
            int dage;
            System.Windows.Forms.RadioButton rb = groupBox2.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
            dgender = rb.Text;
            dname = textBoxDename.Text;
            dspecial = textBoxDespecial.Text;
            dyoe = comboBox2.SelectedItem.ToString();
            dnumber = Convert.ToDouble(textBoxDenumber.Text);
            dage = Convert.ToInt32(textBoxDeage.Text);

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                string query = "update DoctorInfo set NAME ='" + dname + "',GENDER = '"+dgender+"',AGE = '"+dage+"',CONTACT_NUMBER = '"+dnumber+"',SPECIALIZATION ='"+dspecial+"',YRS_OF_EXPERIENCE='"+dyoe+"' where Id = '"+textBoxgetd_id.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");                
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
    }
}
