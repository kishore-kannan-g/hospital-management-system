﻿namespace HospitalManagement
{
    partial class FormAppointmentView
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
            this.dataGridViewAppView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAppView
            // 
            this.dataGridViewAppView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppView.Location = new System.Drawing.Point(89, 53);
            this.dataGridViewAppView.Name = "dataGridViewAppView";
            this.dataGridViewAppView.RowHeadersWidth = 51;
            this.dataGridViewAppView.RowTemplate.Height = 24;
            this.dataGridViewAppView.Size = new System.Drawing.Size(873, 400);
            this.dataGridViewAppView.TabIndex = 0;
            // 
            // FormAppointmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.dataGridViewAppView);
            this.Name = "FormAppointmentView";
            this.Text = "FormAppointmentView";
            this.Load += new System.EventHandler(this.FormAppointmentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAppView;
    }
}