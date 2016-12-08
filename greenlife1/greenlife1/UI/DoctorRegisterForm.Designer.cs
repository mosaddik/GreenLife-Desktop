namespace greenlife1
{
    partial class DoctorRegisterForm
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
            this.doctorPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.docotorShedul = new System.Windows.Forms.Label();
            this.docotorQualificationBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.Label();
            this.browseTextBox = new System.Windows.Forms.Button();
            this.docotorRegistrationLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.doctorDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.NIDTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.doctorPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorPanel
            // 
            this.doctorPanel.AccessibleName = "sadasdasd";
            this.doctorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doctorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doctorPanel.Controls.Add(this.passwordTextBox);
            this.doctorPanel.Controls.Add(this.passwordLabel);
            this.doctorPanel.Controls.Add(this.listView1);
            this.doctorPanel.Controls.Add(this.endTime);
            this.doctorPanel.Controls.Add(this.startTime);
            this.doctorPanel.Controls.Add(this.button2);
            this.doctorPanel.Controls.Add(this.label11);
            this.doctorPanel.Controls.Add(this.label10);
            this.doctorPanel.Controls.Add(this.label3);
            this.doctorPanel.Controls.Add(this.dayComboBox);
            this.doctorPanel.Controls.Add(this.docotorShedul);
            this.doctorPanel.Controls.Add(this.docotorQualificationBox);
            this.doctorPanel.Controls.Add(this.label1);
            this.doctorPanel.Controls.Add(this.phoneBox);
            this.doctorPanel.Controls.Add(this.phoneTextBox);
            this.doctorPanel.Controls.Add(this.browseTextBox);
            this.doctorPanel.Controls.Add(this.docotorRegistrationLabel);
            this.doctorPanel.Controls.Add(this.registerButton);
            this.doctorPanel.Controls.Add(this.doctorDatePicker);
            this.doctorPanel.Controls.Add(this.panel1);
            this.doctorPanel.Controls.Add(this.NIDTextBox);
            this.doctorPanel.Controls.Add(this.AddressTextBox);
            this.doctorPanel.Controls.Add(this.emailTextBox);
            this.doctorPanel.Controls.Add(this.nameTextBox);
            this.doctorPanel.Controls.Add(this.imageTextBox);
            this.doctorPanel.Controls.Add(this.label9);
            this.doctorPanel.Controls.Add(this.label8);
            this.doctorPanel.Controls.Add(this.label7);
            this.doctorPanel.Controls.Add(this.label6);
            this.doctorPanel.Controls.Add(this.label5);
            this.doctorPanel.Controls.Add(this.label4);
            this.doctorPanel.Controls.Add(this.nameLabel);
            this.doctorPanel.Controls.Add(this.label2);
            this.doctorPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.doctorPanel.Location = new System.Drawing.Point(54, 23);
            this.doctorPanel.Name = "doctorPanel";
            this.doctorPanel.Size = new System.Drawing.Size(987, 491);
            this.doctorPanel.TabIndex = 0;
            this.doctorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.doctorPanel_Paint);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(613, 191);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(348, 205);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(857, 83);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(94, 20);
            this.endTime.TabIndex = 35;
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(726, 83);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(94, 20);
            this.startTime.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(900, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(826, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "end";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(692, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "day";
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Location = new System.Drawing.Point(587, 83);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(88, 21);
            this.dayComboBox.TabIndex = 28;
            // 
            // docotorShedul
            // 
            this.docotorShedul.AutoSize = true;
            this.docotorShedul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docotorShedul.Location = new System.Drawing.Point(662, 45);
            this.docotorShedul.Name = "docotorShedul";
            this.docotorShedul.Size = new System.Drawing.Size(134, 22);
            this.docotorShedul.TabIndex = 27;
            this.docotorShedul.Text = "Doctor Shedule";
            // 
            // docotorQualificationBox
            // 
            this.docotorQualificationBox.Location = new System.Drawing.Point(112, 264);
            this.docotorQualificationBox.Name = "docotorQualificationBox";
            this.docotorQualificationBox.Size = new System.Drawing.Size(328, 42);
            this.docotorQualificationBox.TabIndex = 26;
            this.docotorQualificationBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Qualification";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(112, 158);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(328, 20);
            this.phoneBox.TabIndex = 24;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.AutoSize = true;
            this.phoneTextBox.Location = new System.Drawing.Point(42, 158);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(37, 13);
            this.phoneTextBox.TabIndex = 23;
            this.phoneTextBox.Text = "phone";
            // 
            // browseTextBox
            // 
            this.browseTextBox.Location = new System.Drawing.Point(365, 76);
            this.browseTextBox.Name = "browseTextBox";
            this.browseTextBox.Size = new System.Drawing.Size(75, 23);
            this.browseTextBox.TabIndex = 21;
            this.browseTextBox.Text = "Browse";
            this.browseTextBox.UseVisualStyleBackColor = true;
            this.browseTextBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // docotorRegistrationLabel
            // 
            this.docotorRegistrationLabel.AutoSize = true;
            this.docotorRegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docotorRegistrationLabel.Location = new System.Drawing.Point(293, -2);
            this.docotorRegistrationLabel.Name = "docotorRegistrationLabel";
            this.docotorRegistrationLabel.Size = new System.Drawing.Size(267, 31);
            this.docotorRegistrationLabel.TabIndex = 20;
            this.docotorRegistrationLabel.Text = "Doctor Registration";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(441, 440);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(119, 44);
            this.registerButton.TabIndex = 19;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // doctorDatePicker
            // 
            this.doctorDatePicker.CustomFormat = "MM:HH";
            this.doctorDatePicker.Location = new System.Drawing.Point(112, 339);
            this.doctorDatePicker.Name = "doctorDatePicker";
            this.doctorDatePicker.Size = new System.Drawing.Size(200, 20);
            this.doctorDatePicker.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.femaleRadio);
            this.panel1.Controls.Add(this.maleRadio);
            this.panel1.Location = new System.Drawing.Point(112, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 25);
            this.panel1.TabIndex = 17;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(104, 5);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 1;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(13, 4);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(48, 17);
            this.maleRadio.TabIndex = 0;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // NIDTextBox
            // 
            this.NIDTextBox.Location = new System.Drawing.Point(112, 312);
            this.NIDTextBox.Name = "NIDTextBox";
            this.NIDTextBox.Size = new System.Drawing.Size(328, 20);
            this.NIDTextBox.TabIndex = 15;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(112, 376);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(328, 20);
            this.AddressTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(112, 184);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(328, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(112, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(328, 20);
            this.nameTextBox.TabIndex = 11;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(112, 76);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(247, 20);
            this.imageTextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Specility";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "NID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Picture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(52, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(38, 228);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 37;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(112, 221);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(328, 20);
            this.passwordTextBox.TabIndex = 38;
            // 
            // DoctorRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 537);
            this.Controls.Add(this.doctorPanel);
            this.Name = "DoctorRegisterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.doctorPanel.ResumeLayout(false);
            this.doctorPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel doctorPanel;
        private System.Windows.Forms.TextBox NIDTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.DateTimePicker doctorDatePicker;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label docotorRegistrationLabel;
        private System.Windows.Forms.Button browseTextBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label phoneTextBox;
        private System.Windows.Forms.RichTextBox docotorQualificationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Label docotorShedul;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}

