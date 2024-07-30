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
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {

        }
  

        private void button1_Click(object sender, EventArgs e)
        {
            FormDoctor2 formDoctor2 = new FormDoctor2();
            splitContainer_Panel2(formDoctor2);
        }

        private void buttonDview_Click(object sender, EventArgs e)
        {
            FormDoctorView formDoctorView = new FormDoctorView();
            splitContainer_Panel2(formDoctorView);
        }

        public void splitContainer_Panel2(Form form)
        {
            splitContainer1.Panel2.Controls.Clear();            
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDoctoredit formDoctoredit = new FormDoctoredit();
            splitContainer_Panel2(formDoctoredit);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDoctordelete doctordelete = new FormDoctordelete();
            splitContainer_Panel2(doctordelete);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {
        }
    }
}
