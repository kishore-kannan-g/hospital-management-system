﻿namespace HospitalManagement
{
    partial class FormDoctorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDview2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(908, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonDview2
            // 
            this.buttonDview2.BackColor = System.Drawing.Color.Red;
            this.buttonDview2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDview2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDview2.ForeColor = System.Drawing.Color.White;
            this.buttonDview2.Location = new System.Drawing.Point(315, 466);
            this.buttonDview2.Name = "buttonDview2";
            this.buttonDview2.Size = new System.Drawing.Size(305, 54);
            this.buttonDview2.TabIndex = 2;
            this.buttonDview2.Text = "VIEW ALL DOCTOR DATA";
            this.buttonDview2.UseVisualStyleBackColor = false;
            this.buttonDview2.Click += new System.EventHandler(this.buttonDview2_Click);
            // 
            // FormDoctorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.buttonDview2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDoctorView";
            this.Text = "FormDoctorView";
            this.Load += new System.EventHandler(this.FormDoctorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDview2;
    }
}