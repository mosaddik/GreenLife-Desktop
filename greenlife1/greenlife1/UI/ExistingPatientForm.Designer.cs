namespace greenlife1.UI
{
    partial class ExistingPatientForm
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
            this.ExistingPatientLabel = new System.Windows.Forms.Label();
            this.searchPatientText = new System.Windows.Forms.TextBox();
            this.viewPatientGrid = new System.Windows.Forms.DataGridView();
            this.searchPatientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewPatientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ExistingPatientLabel
            // 
            this.ExistingPatientLabel.AutoSize = true;
            this.ExistingPatientLabel.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingPatientLabel.Location = new System.Drawing.Point(57, 36);
            this.ExistingPatientLabel.Name = "ExistingPatientLabel";
            this.ExistingPatientLabel.Size = new System.Drawing.Size(180, 31);
            this.ExistingPatientLabel.TabIndex = 0;
            this.ExistingPatientLabel.Text = "Existing Patient";
            // 
            // searchPatientText
            // 
            this.searchPatientText.Location = new System.Drawing.Point(1016, 77);
            this.searchPatientText.Name = "searchPatientText";
            this.searchPatientText.Size = new System.Drawing.Size(205, 20);
            this.searchPatientText.TabIndex = 1;
            this.searchPatientText.TextChanged += new System.EventHandler(this.searchPatientText_TextChanged);
            // 
            // viewPatientGrid
            // 
            this.viewPatientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewPatientGrid.Location = new System.Drawing.Point(63, 130);
            this.viewPatientGrid.Name = "viewPatientGrid";
            this.viewPatientGrid.Size = new System.Drawing.Size(1279, 458);
            this.viewPatientGrid.TabIndex = 2;
            this.viewPatientGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewPatientGrid_CellClick);
            this.viewPatientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewPatientGrid_CellContentClick);
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.Location = new System.Drawing.Point(1257, 77);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(75, 23);
            this.searchPatientButton.TabIndex = 3;
            this.searchPatientButton.Text = "Search";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            this.searchPatientButton.Click += new System.EventHandler(this.searchPatientButton_Click);
            // 
            // ExistingPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 503);
            this.Controls.Add(this.searchPatientButton);
            this.Controls.Add(this.viewPatientGrid);
            this.Controls.Add(this.searchPatientText);
            this.Controls.Add(this.ExistingPatientLabel);
            this.Name = "ExistingPatientForm";
            this.Text = "ExistingPatientForm";
            this.Load += new System.EventHandler(this.ExistingPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewPatientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExistingPatientLabel;
        private System.Windows.Forms.TextBox searchPatientText;
        private System.Windows.Forms.DataGridView viewPatientGrid;
        private System.Windows.Forms.Button searchPatientButton;
    }
}