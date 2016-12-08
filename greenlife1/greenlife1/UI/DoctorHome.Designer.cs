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
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waitingPatientGrid = new System.Windows.Forms.DataGridView();
            this.callPatient = new System.Windows.Forms.Button();
            this.showPatientDetailButton = new System.Windows.Forms.Button();
            this.QueueInfo = new System.Windows.Forms.Label();
            this.QueueInfoLabel = new System.Windows.Forms.Label();
            this.doctorHomePanel.SuspendLayout();
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
            this.doctorHomePanel.Controls.Add(this.PatientNameLabel);
            this.doctorHomePanel.Controls.Add(this.label2);
            this.doctorHomePanel.Location = new System.Drawing.Point(12, 76);
            this.doctorHomePanel.Name = "doctorHomePanel";
            this.doctorHomePanel.Size = new System.Drawing.Size(526, 399);
            this.doctorHomePanel.TabIndex = 1;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Location = new System.Drawing.Point(120, 50);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(35, 13);
            this.PatientNameLabel.TabIndex = 1;
            this.PatientNameLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patient Name";
            // 
            // waitingPatientGrid
            // 
            this.waitingPatientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitingPatientGrid.Location = new System.Drawing.Point(643, 76);
            this.waitingPatientGrid.Name = "waitingPatientGrid";
            this.waitingPatientGrid.Size = new System.Drawing.Size(355, 399);
            this.waitingPatientGrid.TabIndex = 0;
            this.waitingPatientGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.waitingPatientGrid_CellClick);
            // 
            // callPatient
            // 
            this.callPatient.Location = new System.Drawing.Point(780, 47);
            this.callPatient.Name = "callPatient";
            this.callPatient.Size = new System.Drawing.Size(76, 23);
            this.callPatient.TabIndex = 2;
            this.callPatient.Text = "Call Patient";
            this.callPatient.UseVisualStyleBackColor = true;
            this.callPatient.Click += new System.EventHandler(this.callPatient_Click);
            // 
            // showPatientDetailButton
            // 
            this.showPatientDetailButton.Location = new System.Drawing.Point(643, 47);
            this.showPatientDetailButton.Name = "showPatientDetailButton";
            this.showPatientDetailButton.Size = new System.Drawing.Size(122, 23);
            this.showPatientDetailButton.TabIndex = 4;
            this.showPatientDetailButton.Text = "Show Patient Detail";
            this.showPatientDetailButton.UseVisualStyleBackColor = true;
            this.showPatientDetailButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // QueueInfo
            // 
            this.QueueInfo.AutoSize = true;
            this.QueueInfo.Location = new System.Drawing.Point(828, 52);
            this.QueueInfo.Name = "QueueInfo";
            this.QueueInfo.Size = new System.Drawing.Size(0, 13);
            this.QueueInfo.TabIndex = 5;
            // 
            // QueueInfoLabel
            // 
            this.QueueInfoLabel.AutoSize = true;
            this.QueueInfoLabel.Location = new System.Drawing.Point(883, 52);
            this.QueueInfoLabel.Name = "QueueInfoLabel";
            this.QueueInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.QueueInfoLabel.TabIndex = 6;
            this.QueueInfoLabel.Text = "label3";
            // 
            // DoctorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 509);
            this.Controls.Add(this.QueueInfoLabel);
            this.Controls.Add(this.QueueInfo);
            this.Controls.Add(this.showPatientDetailButton);
            this.Controls.Add(this.callPatient);
            this.Controls.Add(this.waitingPatientGrid);
            this.Controls.Add(this.doctorHomePanel);
            this.Controls.Add(this.label1);
            this.Name = "DoctorHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DoctorHome_Load);
            this.doctorHomePanel.ResumeLayout(false);
            this.doctorHomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingPatientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel doctorHomePanel;
        private System.Windows.Forms.DataGridView waitingPatientGrid;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button callPatient;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showPatientDetailButton;
        private System.Windows.Forms.Label QueueInfo;
        private System.Windows.Forms.Label QueueInfoLabel;

    }
}