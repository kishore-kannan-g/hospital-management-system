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
    public partial class FormPatient1 : Form
    {
        public FormPatient1()
        {
            InitializeComponent();
        }

        private void buttonPatientAdd_Click(object sender, EventArgs e)
        {
            FormPatientAdd formPatientAdd = new FormPatientAdd();
            splitContainer2_panel2(formPatientAdd);
        }

        public void splitContainer2_panel2(Form form)
        {
            splitContainer2.Panel2.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(form);
            form.Show();
        }

        private void buttonPatientview_Click(object sender, EventArgs e)
        {
            FormPatientView formPatientView = new FormPatientView();
            splitContainer2_panel2(formPatientView);
        }

        private void buttonPatientEdit_Click(object sender, EventArgs e)
        {
            FormPatientEdit formPatientEdit = new FormPatientEdit();
            splitContainer2_panel2(formPatientEdit);
        }

        private void buttonPatientDelete_Click(object sender, EventArgs e)
        {
            FormPatientDelete formPatientDelete = new FormPatientDelete();
            splitContainer2_panel2(formPatientDelete);
        }
    }
}
