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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagement
{
    public partial class FormPatientEdit : Form
    {
        public FormPatientEdit()
        {
            InitializeComponent();
        }

        private void buttongetPatient_Click(object sender, EventArgs e)
        {
            string doc_id = textBoxgetd_id.Text;
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
                    textBoxPname.Text = rdr["NAME"].ToString();
                    textBoxPage.Text = rdr["AGE"].ToString();
                    textBoxPnumber.Text = rdr["CONTACT_NUMBER"].ToString();
                    string gender = rdr["GENDER"].ToString();
                    if (gender == "Male")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    comboBox2.SelectedItem = rdr["BLOOD_GROUP"].ToString();
                    textBoxPallergy.Text = rdr["ALLERGIES"].ToString();
                    textBoxPcurrent.Text = rdr["MEDICATION"].ToString();
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

        private void buttoneditPatient_Click(object sender, EventArgs e)
        {
            
        }

        private void buttoneditPatient_Click_1(object sender, EventArgs e)
        {
            string pname, pgender, pallergy, pcurrent, pblood;
            double pnumber;
            int page;
            RadioButton rb = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            pgender = rb.Text;
            pname = textBoxPname.Text;
            pallergy = textBoxPallergy.Text;
            pcurrent = textBoxPcurrent.Text;
            if (pallergy == "")
            { pallergy = "Nil"; }
            if (pcurrent == "")
            { pcurrent = "Nil"; }
            pblood = comboBox2.SelectedItem.ToString();
            pnumber = Convert.ToDouble(textBoxPnumber.Text);
            page = Convert.ToInt32(textBoxPage.Text);

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                string query = "update PatientInfo set NAME ='" + pname + "',GENDER = '" + pgender + "',AGE = '" + page + "',CONTACT_NUMBER = '" + pnumber + "',BLOOD_GROUP ='" + pblood + "',ALLERGIES='" + pallergy + "',MEDICATIONS ='" + pcurrent + "' where Id = '" + textBoxgetd_id.Text + "'";
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

        private void textBoxPname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
