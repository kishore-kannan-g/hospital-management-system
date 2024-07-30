﻿using System;
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
    public partial class FormPatientView : Form
    {
        public FormPatientView()
        {
            InitializeComponent();
        }

        private void buttonPview2_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Doctor;Integrated Security=True");
                string query = "SELECT * FROM PatientInfo";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rdr);
                dataGridView2.DataSource = dataTable;
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
