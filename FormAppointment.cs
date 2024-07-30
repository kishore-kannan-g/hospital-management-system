using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace HospitalManagement
{
    public partial class FormAppointment : Form
    {
        public FormAppointment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAppointment_Load(object sender, EventArgs e)
        {          
        }

        private void buttonAppoint1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string disease = textBox2.Text;
            int time = comboBoxTime.SelectedIndex;
            string time2 = comboBoxTime.SelectedItem.ToString();

            SqlConnection con = null;
            try
            {
                if (disease.Contains("heart"))
                {
                        con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                        string query = "SELECT * FROM DoctorInfo where SPECIALIZATION = '" + "Heart Surgeon" + "' and WORKING_HRS = '"+time2+"' ";
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "DoctorInfo");
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Doctors not available ,.. Pls choose another time");
                    }
                    else
                    {
                        dataGridViewAppointment.DataSource = set.Tables["DoctorInfo"];
                    }
                    
                }
                if (disease.Contains("child"))
                {
                    con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                    string query = "SELECT * FROM DoctorInfo where SPECIALIZATION = '" + "Child Specialist" + "' and WORKING_HRS = '"+time2+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "DoctorInfo");
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Doctors not available ,.. Pls choose another time");
                    }
                    else
                    {
                        dataGridViewAppointment.DataSource = set.Tables["DoctorInfo"];
                    }
                }
                if (disease.Contains("teeth") || disease.Contains("dental"))
                {
                    con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                    string query = "SELECT * FROM DoctorInfo where SPECIALIZATION = '" + "Dental Specialist" + "' and WORKING_HRS = '"+time2+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "DoctorInfo");
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Doctors not available ,.. Pls choose another time");
                    }
                    else
                    {
                        dataGridViewAppointment.DataSource = set.Tables["DoctorInfo"];
                    }
                }
                if (disease.Contains("brain"))
                {
                    con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                    string query = "SELECT * FROM DoctorInfo where SPECIALIZATION = '" + "Neurologist" + "' and WORKING_HRS = '"+time2+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "DoctorInfo");
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Doctors not available ,.. Pls choose another time");
                    }
                    else
                    {
                        dataGridViewAppointment.DataSource = set.Tables["DoctorInfo"];
                    }
                }
                if (disease.Contains("plastic"))
                {
                    con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                    string query = "SELECT * FROM DoctorInfo where SPECIALIZATION = '" + "Plastic Surgeon" + "' and WORKING_HRS = '"+time2+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "DoctorInfo");
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Doctors not available ,.. Pls choose another time");
                    }
                    else
                    {
                        dataGridViewAppointment.DataSource = set.Tables["DoctorInfo"];
                    }
                }
                if (disease.Contains("eye"))
                {
                    con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                    string query = "SELECT * FROM DoctorInfo where SPECIALIZATION = '" + "Eye Specialist" + "' and WORKING_HRS = '"+time2+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "DoctorInfo");
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Doctors not available ,.. Pls choose another time");
                    }
                    else
                    {
                        dataGridViewAppointment.DataSource = set.Tables["DoctorInfo"];
                    }
                }
                if (disease.Contains("skin"))
                {
                    con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                    string query = "SELECT * FROM DoctorInfo where SPECIALIZATION = '" + "Skin Specialist" + "' and WORKING_HRS = '"+time2+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "DoctorInfo");
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Doctors not available ,.. Pls choose another time");
                    }
                    else
                    {
                        dataGridViewAppointment.DataSource = set.Tables["DoctorInfo"];
                    }
                }
                if (disease.Contains("hair"))
                {
                    con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                    string query = "SELECT * FROM DoctorInfo where SPECIALIZATION = '" + "Hair Specialist" + "' and WORKING_HRS = '"+time2+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "DoctorInfo");
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Doctors not available ,.. Pls choose another time");
                    }
                    else
                    {
                        dataGridViewAppointment.DataSource = set.Tables["DoctorInfo"];
                    }
                }
                if (disease.Contains("cancer"))
                {
                    con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                    string query = "SELECT * FROM DoctorInfo where SPECIALIZATION = '" + "Cancer Specialist" + "' and WORKING_HRS = '"+time2+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "DoctorInfo");
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Doctors not available ,.. Pls choose another time");
                    }
                    else
                    {
                        dataGridViewAppointment.DataSource = set.Tables["DoctorInfo"];
                    }
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

        public void dataGridViewAppointment_SelectionChanged(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridViewAppointment.CurrentRow.DataBoundItem).Row;
            labelDname.Text = row["Name"].ToString();
            labelDage.Text = row["Age"].ToString();
            labelDgender.Text = row["Gender"].ToString();
            labelDnumber.Text = row["Contact_Number"].ToString();
            labelDspecial.Text = row["Specialization"].ToString();
            labelDyrs.Text = row["YRS_OF_EXPERIENCE"].ToString();
            labelDid.Text = row["Id"].ToString();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                con.Open();
                string query = "select NAME from PatientInfo where Id = '" + textBoxPid.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    labelPname.Text = rdr["NAME"].ToString();
                }
                else
                {
                    labelPname.Text = "";
                    MessageBox.Show("Register yourself as Patient First");
                }
            }
            catch (Exception ex) { Console.WriteLine("Error"); }
            finally { con.Close(); }
        }

        public void buttonFixApp_Click(object sender, EventArgs e)
        {
            string Pid, Pname, Dname,Did,Adate;
            int flag;
            flag = 0;
            Pid = textBoxPid.Text;
            Pname = labelPname.Text;
            Dname = labelDname.Text;
            Adate = DateTime.Now.ToShortDateString();
            Did = labelDid.Text;
            string time2 = comboBoxTime.SelectedItem.ToString();

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                con.Open();

                string pcheck = "select PATIENT_NAME from Appointment where PATIENT_ID = '"+Pid+"' ";
                SqlCommand p1 = new SqlCommand(pcheck, con);
                SqlDataReader read1 = p1.ExecuteReader();
                if (read1.Read())
                {
                    MessageBox.Show(read1["PATIENT_NAME"] + " is already in an Appointmnet");
                }
                else
                {
                    flag = flag + 1;
                }                
            }
            catch (Exception ex) { Console.WriteLine("Error"); }
            finally { con.Close(); }

            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                con.Open();

                string dcheck = "select DOCTOR_NAME from Appointment where DOCTOR_ID = '" + Did + "' ";
                SqlCommand d1 = new SqlCommand(dcheck, con);
                SqlDataReader read2 = d1.ExecuteReader();
                if (read2.Read())
                {
                    MessageBox.Show(read2["DOCTOR_NAME"] + " is already in an Appointmnet");
                }
                else
                {
                    flag = flag + 1;
                }
            }
            catch (Exception ex) { Console.WriteLine("Error"); }
            finally { con.Close(); }

            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                con.Open();

                if (flag == 2)
                {
                    string query = "INSERT INTO Appointment(PATIENT_ID,PATIENT_NAME,DOCTOR_ID,DOCTOR_NAME,DATE,TIME) VALUES('" + Pid + "','" + Pname + "','" + Did + "','" + Dname + "','" + Adate + "','"+time2+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Successful");
                }
            }
            catch (Exception ex) { Console.WriteLine("Error"); }
            finally { con.Close(); }
        }

        private void dataGridViewAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}