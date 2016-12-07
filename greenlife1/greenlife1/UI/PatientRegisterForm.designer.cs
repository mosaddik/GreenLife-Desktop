namespace Greenlife1
{
    partial class PatientRegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.formLabel = new System.Windows.Forms.Label();
            this.problemRichTextBox = new System.Windows.Forms.RichTextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.patientDatePicker = new System.Windows.Forms.DateTimePicker();
            this.NIDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.NIDLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.problemLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.formLabel);
            this.panel1.Controls.Add(this.problemRichTextBox);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Controls.Add(this.patientDatePicker);
            this.panel1.Controls.Add(this.NIDTextBox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.imageTextBox);
            this.panel1.Controls.Add(this.NIDLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.problemLabel);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.DOBLabel);
            this.panel1.Controls.Add(this.phoneLabel);
            this.panel1.Controls.Add(this.imageLabel);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.genderLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(54, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 508);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(485, 19);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(208, 31);
            this.formLabel.TabIndex = 5;
            this.formLabel.Text = "Patient Register";
            // 
            // problemRichTextBox
            // 
            this.problemRichTextBox.Location = new System.Drawing.Point(432, 344);
            this.problemRichTextBox.Name = "problemRichTextBox";
            this.problemRichTextBox.Size = new System.Drawing.Size(326, 46);
            this.problemRichTextBox.TabIndex = 4;
            this.problemRichTextBox.Text = "";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(527, 443);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(115, 24);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(683, 226);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // patientDatePicker
            // 
            this.patientDatePicker.Location = new System.Drawing.Point(432, 252);
            this.patientDatePicker.Name = "patientDatePicker";
            this.patientDatePicker.Size = new System.Drawing.Size(326, 20);
            this.patientDatePicker.TabIndex = 2;
            // 
            // NIDTextBox
            // 
            this.NIDTextBox.Location = new System.Drawing.Point(432, 306);
            this.NIDTextBox.Name = "NIDTextBox";
            this.NIDTextBox.Size = new System.Drawing.Size(326, 20);
            this.NIDTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(432, 278);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(326, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(432, 226);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(245, 20);
            this.imageTextBox.TabIndex = 1;
            this.imageTextBox.TextChanged += new System.EventHandler(this.imageTextBox_TextChanged);
            // 
            // NIDLabel
            // 
            this.NIDLabel.AutoSize = true;
            this.NIDLabel.Location = new System.Drawing.Point(370, 309);
            this.NIDLabel.Name = "NIDLabel";
            this.NIDLabel.Size = new System.Drawing.Size(26, 13);
            this.NIDLabel.TabIndex = 0;
            this.NIDLabel.Text = "NID";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(432, 190);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(326, 20);
            this.phoneTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(433, 164);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(325, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(433, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(325, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.Location = new System.Drawing.Point(370, 350);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(45, 13);
            this.problemLabel.TabIndex = 0;
            this.problemLabel.Text = "Problem";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(370, 281);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(344, 252);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(68, 13);
            this.DOBLabel.TabIndex = 0;
            this.DOBLabel.Text = "Date Of Birth";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(374, 193);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Phone";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(370, 226);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(36, 13);
            this.imageLabel.TabIndex = 0;
            this.imageLabel.Text = "Image";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(375, 167);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(371, 109);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Gender";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(371, 86);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.femaleRadio);
            this.panel2.Controls.Add(this.maleRadio);
            this.panel2.Location = new System.Drawing.Point(433, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 26);
            this.panel2.TabIndex = 0;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(94, 6);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 2;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.Location = new System.Drawing.Point(3, 6);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(48, 17);
            this.maleRadio.TabIndex = 2;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // PatientRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 532);
            this.Controls.Add(this.panel1);
            this.Name = "PatientRegisterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PatientRegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label problemLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.DateTimePicker patientDatePicker;
        private System.Windows.Forms.TextBox NIDTextBox;
        private System.Windows.Forms.Label NIDLabel;
        private System.Windows.Forms.RichTextBox problemRichTextBox;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
    }
}

