﻿namespace HospitalManagement
{
    partial class FormAppointmentMain
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
            this.splitContainerApp = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerApp)).BeginInit();
            this.splitContainerApp.Panel1.SuspendLayout();
            this.splitContainerApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerApp
            // 
            this.splitContainerApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerApp.Location = new System.Drawing.Point(0, 0);
            this.splitContainerApp.Name = "splitContainerApp";
            // 
            // splitContainerApp.Panel1
            // 
            this.splitContainerApp.Panel1.BackColor = System.Drawing.Color.Navy;
            this.splitContainerApp.Panel1.Controls.Add(this.button3);
            this.splitContainerApp.Panel1.Controls.Add(this.button2);
            this.splitContainerApp.Panel1.Controls.Add(this.button1);
            this.splitContainerApp.Size = new System.Drawing.Size(1362, 553);
            this.splitContainerApp.SplitterDistance = 198;
            this.splitContainerApp.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 89);
            this.button3.TabIndex = 2;
            this.button3.Text = "DELETE APPOINTMENT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "VIEW ALL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "FIX APPOINTMENT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAppointmentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 553);
            this.Controls.Add(this.splitContainerApp);
            this.Name = "FormAppointmentMain";
            this.Text = "FormAppointmentMain";
            this.splitContainerApp.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerApp)).EndInit();
            this.splitContainerApp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerApp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}