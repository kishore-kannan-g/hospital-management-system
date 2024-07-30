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
    public partial class FormPatientAdd : Form
    {
        public FormPatientAdd()
        {
            InitializeComponent();
        }

        private void buttonDadd_Click(object sender, EventArgs e)
        {
            
        }

        private void FormPatientAdd_Load(object sender, EventArgs e)
        {

        }

        private void buttonDadd_Click_1(object sender, EventArgs e)
        {
            string pname, pgender, pallergy, pcurrent, pblood;
            double pnumber;
            int page;
            RadioButton rb = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            pgender = rb.Text;
            pname = textBoxPname.Text;            
            pallergy = textBoxPallergy.Text;            
            pcurrent = textBoxPcurrent.Text;
            if(pallergy=="")
            { pallergy = "Nil"; }
            if(pcurrent=="")
            { pcurrent = "Nil"; }
            pblood = comboBox1.SelectedItem.ToString();
            pnumber = Convert.ToDouble(textBoxPnumber.Text);
            page = Convert.ToInt32(textBoxPage.Text);
            

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                string query = "INSERT INTO PatientInfo(NAME,AGE,GENDER,BLOOD_GROUP,ALLERGIES,CONTACT_NUMBER,MEDICATIONS) VALUES('" + pname + "','" + page + "','" + pgender + "','" + pblood + "','" + pallergy + "','" + pnumber + "','" + pcurrent + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added");

                string query2 = "Select Id from PatientInfo where NAME = '" + pname + "' ";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.ExecuteNonQuery();
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Your Id = "+reader["Id"].ToString());
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
    }
}
