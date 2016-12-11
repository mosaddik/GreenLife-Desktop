namespace greenlife1.UI
{
    partial class PaymentForm
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
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.recievedLabel = new System.Windows.Forms.Label();
            this.payableLabelTop = new System.Windows.Forms.Label();
            this.payableEditLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.particularComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Location = new System.Drawing.Point(53, 50);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(65, 13);
            this.doctorNameLabel.TabIndex = 0;
            this.doctorNameLabel.Text = "doctorName";
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(139, 47);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(100, 20);
            this.feeTextBox.TabIndex = 1;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeLabel.Location = new System.Drawing.Point(171, 28);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(35, 16);
            this.feeLabel.TabIndex = 2;
            this.feeLabel.Text = "Fee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // recievedLabel
            // 
            this.recievedLabel.AutoSize = true;
            this.recievedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recievedLabel.Location = new System.Drawing.Point(284, 28);
            this.recievedLabel.Name = "recievedLabel";
            this.recievedLabel.Size = new System.Drawing.Size(75, 16);
            this.recievedLabel.TabIndex = 4;
            this.recievedLabel.Text = "Recieved";
            // 
            // payableLabelTop
            // 
            this.payableLabelTop.AutoSize = true;
            this.payableLabelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payableLabelTop.Location = new System.Drawing.Point(427, 28);
            this.payableLabelTop.Name = "payableLabelTop";
            this.payableLabelTop.Size = new System.Drawing.Size(66, 16);
            this.payableLabelTop.TabIndex = 5;
            this.payableLabelTop.Text = "Payable";
            // 
            // payableEditLabel
            // 
            this.payableEditLabel.AutoSize = true;
            this.payableEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payableEditLabel.Location = new System.Drawing.Point(397, 45);
            this.payableEditLabel.Name = "payableEditLabel";
            this.payableEditLabel.Size = new System.Drawing.Size(120, 20);
            this.payableEditLabel.TabIndex = 6;
            this.payableEditLabel.Text = "payableAmount";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(546, 44);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // particularComboBox
            // 
            this.particularComboBox.FormattingEnabled = true;
            this.particularComboBox.Location = new System.Drawing.Point(139, 102);
            this.particularComboBox.Name = "particularComboBox";
            this.particularComboBox.Size = new System.Drawing.Size(201, 21);
            this.particularComboBox.TabIndex = 8;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(12, 102);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(119, 16);
            this.categoryLabel.TabIndex = 9;
            this.categoryLabel.Text = "Select Category";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(437, 236);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(184, 52);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 320);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.particularComboBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.payableEditLabel);
            this.Controls.Add(this.payableLabelTop);
            this.Controls.Add(this.recievedLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.feeTextBox);
            this.Controls.Add(this.doctorNameLabel);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.TextBox feeTextBox;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label recievedLabel;
        private System.Windows.Forms.Label payableLabelTop;
        private System.Windows.Forms.Label payableEditLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox particularComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button submitButton;
    }
}