namespace greenlife1
{
    partial class DoctorHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.doctorHomePanel = new System.Windows.Forms.Panel();
            this.waitingPatientGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.waitingPatientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Home";
            // 
            // doctorHomePanel
            // 
            this.doctorHomePanel.Location = new System.Drawing.Point(12, 70);
            this.doctorHomePanel.Name = "doctorHomePanel";
            this.doctorHomePanel.Size = new System.Drawing.Size(609, 405);
            this.doctorHomePanel.TabIndex = 1;
            // 
            // waitingPatientGrid
            // 
            this.waitingPatientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitingPatientGrid.Location = new System.Drawing.Point(675, 60);
            this.waitingPatientGrid.Name = "waitingPatientGrid";
            this.waitingPatientGrid.Size = new System.Drawing.Size(355, 399);
            this.waitingPatientGrid.TabIndex = 0;
            // 
            // DoctorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 509);
            this.Controls.Add(this.waitingPatientGrid);
            this.Controls.Add(this.doctorHomePanel);
            this.Controls.Add(this.label1);
            this.Name = "DoctorHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DoctorHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waitingPatientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel doctorHomePanel;
        private System.Windows.Forms.DataGridView waitingPatientGrid;
        internal System.Windows.Forms.Label label1;

    }
}