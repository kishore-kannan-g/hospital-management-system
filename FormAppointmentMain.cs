using System;
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
    public partial class FormAppointmentMain : Form
    {
        public FormAppointmentMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAppointment form = new FormAppointment();
            splitContainerApp_Panel2(form);
        }
        public void splitContainerApp_Panel2(Form form)
        {
            splitContainerApp.Panel2.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerApp.Panel2.Controls.Add(form);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAppointmentView form = new FormAppointmentView();
            splitContainerApp_Panel2(form);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAppointmentDel form = new FormAppointmentDel();
            splitContainerApp_Panel2(form);
        }
    }
}
