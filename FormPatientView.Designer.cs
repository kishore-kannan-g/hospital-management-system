namespace HospitalManagement
{
    partial class FormPatientView
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
            this.buttonPview2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPview2
            // 
            this.buttonPview2.BackColor = System.Drawing.Color.Red;
            this.buttonPview2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPview2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPview2.ForeColor = System.Drawing.Color.White;
            this.buttonPview2.Location = new System.Drawing.Point(325, 469);
            this.buttonPview2.Name = "buttonPview2";
            this.buttonPview2.Size = new System.Drawing.Size(305, 54);
            this.buttonPview2.TabIndex = 4;
            this.buttonPview2.Text = "VIEW ALL PATIENT DATA";
            this.buttonPview2.UseVisualStyleBackColor = false;
            this.buttonPview2.Click += new System.EventHandler(this.buttonPview2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(900, 420);
            this.dataGridView2.TabIndex = 3;
            // 
            // FormPatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.buttonPview2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormPatientView";
            this.Text = "FormPatientView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPview2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}