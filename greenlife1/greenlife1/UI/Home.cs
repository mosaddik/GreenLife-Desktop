﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Greenlife1;

namespace greenlife1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorRegisterForm doctor = new DoctorRegisterForm();
            doctor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientRegisterForm patientRegisterForm =  new PatientRegisterForm();
            patientRegisterForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
           
            
        
        }
    }
}
