namespace HospitalManagement
{
    partial class FormPatient1
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonPatientDelete = new System.Windows.Forms.Button();
            this.buttonPatientEdit = new System.Windows.Forms.Button();
            this.buttonPatientview = new System.Windows.Forms.Button();
            this.buttonPatientAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.splitContainer2.Panel1.Controls.Add(this.buttonPatientDelete);
            this.splitContainer2.Panel1.Controls.Add(this.buttonPatientEdit);
            this.splitContainer2.Panel1.Controls.Add(this.buttonPatientview);
            this.splitContainer2.Panel1.Controls.Add(this.buttonPatientAdd);
            this.splitContainer2.Size = new System.Drawing.Size(1334, 553);
            this.splitContainer2.SplitterDistance = 352;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonPatientDelete
            // 
            this.buttonPatientDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonPatientDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPatientDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatientDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientDelete.Location = new System.Drawing.Point(69, 235);
            this.buttonPatientDelete.Name = "buttonPatientDelete";
            this.buttonPatientDelete.Size = new System.Drawing.Size(213, 60);
            this.buttonPatientDelete.TabIndex = 7;
            this.buttonPatientDelete.Text = "DELETE PROFILE";
            this.buttonPatientDelete.UseVisualStyleBackColor = false;
            this.buttonPatientDelete.Click += new System.EventHandler(this.buttonPatientDelete_Click);
            // 
            // buttonPatientEdit
            // 
            this.buttonPatientEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonPatientEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPatientEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatientEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientEdit.Location = new System.Drawing.Point(69, 136);
            this.buttonPatientEdit.Name = "buttonPatientEdit";
            this.buttonPatientEdit.Size = new System.Drawing.Size(213, 54);
            this.buttonPatientEdit.TabIndex = 6;
            this.buttonPatientEdit.Text = "EDIT PROFILE";
            this.buttonPatientEdit.UseVisualStyleBackColor = false;
            this.buttonPatientEdit.Click += new System.EventHandler(this.buttonPatientEdit_Click);
            // 
            // buttonPatientview
            // 
            this.buttonPatientview.BackColor = System.Drawing.Color.Transparent;
            this.buttonPatientview.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPatientview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatientview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientview.Location = new System.Drawing.Point(69, 411);
            this.buttonPatientview.Name = "buttonPatientview";
            this.buttonPatientview.Size = new System.Drawing.Size(213, 54);
            this.buttonPatientview.TabIndex = 5;
            this.buttonPatientview.Text = "VIEW ALL";
            this.buttonPatientview.UseVisualStyleBackColor = false;
            this.buttonPatientview.Click += new System.EventHandler(this.buttonPatientview_Click);
            // 
            // buttonPatientAdd
            // 
            this.buttonPatientAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonPatientAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPatientAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatientAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientAdd.Location = new System.Drawing.Point(69, 34);
            this.buttonPatientAdd.Name = "buttonPatientAdd";
            this.buttonPatientAdd.Size = new System.Drawing.Size(213, 54);
            this.buttonPatientAdd.TabIndex = 4;
            this.buttonPatientAdd.Text = "ADD PROFILE";
            this.buttonPatientAdd.UseVisualStyleBackColor = false;
            this.buttonPatientAdd.Click += new System.EventHandler(this.buttonPatientAdd_Click);
            // 
            // FormPatient1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 553);
            this.Controls.Add(this.splitContainer2);
            this.Name = "FormPatient1";
            this.Text = "FormPatient1";
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonPatientDelete;
        private System.Windows.Forms.Button buttonPatientEdit;
        private System.Windows.Forms.Button buttonPatientview;
        private System.Windows.Forms.Button buttonPatientAdd;
    }
}