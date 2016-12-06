namespace greenlife1
{
    partial class AssignDoctorForm
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
            this.assignGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.assignGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // assignGrid
            // 
            this.assignGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignGrid.Location = new System.Drawing.Point(94, 100);
            this.assignGrid.Name = "assignGrid";
            this.assignGrid.Size = new System.Drawing.Size(416, 244);
            this.assignGrid.TabIndex = 0;
            this.assignGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assignGrid_CellClick);
            // 
            // AssignDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 452);
            this.Controls.Add(this.assignGrid);
            this.Name = "AssignDoctorForm";
            this.Text = "AssignDoctorForm";
            this.Load += new System.EventHandler(this.AssignDoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView assignGrid;
    }
}