﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife1.BLL;
using Greenlife1;

namespace greenlife1.UI
{
    public partial class AssignDoctor : Form
    {
       
        public  Patient Patient { get; set; }
        
        public AssignDoctor()
        {
            InitializeComponent();
        }

        public AssignDoctor(Patient patient)
        {
            InitializeComponent();
            this.Patient = patient;

        }

        private void AssignDoctor_Load(object sender, EventArgs e)
        {
            //patientNameLabel.Text = this.Patient.Name;
            patientPhoneLabel.Text = this.Patient.Phone;
            patientProblemLabel.Text = this.Patient.Problem;
            Patient.GridviewLoad(dataGridView1);
        }
        PatientQueueManager patientQueueManager =  new PatientQueueManager();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientQueue queue = new PatientQueue();

            queue.Patient = Patient;

           



            //click button to insert queue
            if (e.ColumnIndex == 4)
            {
              


                //insert into queue
                string doctorid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                queue.Doctor.DoctorId = doctorid;
                queue.PatientEntryDateTime = DateTime.Now;
                queue.State = "INQUEUE";
                queue.QueueNo = patientQueueManager.GenarateQueueNo(doctorid);
                patientQueueManager.AddToQueue(queue);
                DialogResult dialogResult = MessageBox.Show("Patient Queue No is "+ queue.QueueNo);
                this.Close();
                if (dialogResult == DialogResult.OK)
                {
                    new PatientRegisterForm().ShowDialog();

                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
