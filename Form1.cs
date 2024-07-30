﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoctor formDoctor = new FormDoctor();
            formDoctor.ShowDialog();
            formDoctor = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPatient1 formPatient1 = new FormPatient1();
            formPatient1.ShowDialog();
            formPatient1 = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAppointmentMain fappointment = new FormAppointmentMain();
            fappointment.ShowDialog();
            fappointment = null;
            this.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {            

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
