using System;
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

namespace greenlife1
{

    public partial class DoctorHome : Form
    {
        public Doctor Doctor { set; get; }
        DoctorManager doctorManager = new DoctorManager();
        PatientManager patientManager = new PatientManager();
        PatientQueueManager patientQueueManager = new PatientQueueManager();
        public List<Doctor> DoctorWithpatientQueue { set; get; }
        public string DoctorId { set; get; }

        public DoctorHome(string doctor)
        {

            InitializeComponent();
            GridviewLoad(doctor);
            this.Doctor = new Doctor(doctor);
            Doctor.LoadGridVIew(Doctor.DoctorId, waitingPatientGrid, patientQueueManager, patientManager);
            waitingPatientGrid.Hide();

            if (patientQueueManager.GetTopOfTheQueue(Doctor.DoctorId) != null)
            {
                QueueInfoLabel.Text = patientQueueManager.GetQueueByDoctor(Doctor).Count.ToString();
                QueueInfoLabel.Text = QueueInfoLabel.Text + "/" +
                                      patientQueueManager.GetTopOfTheQueue(Doctor.DoctorId).QueueNo;
            }






        }

        private void DoctorHome_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            var patient = new PatientRegisterForm();
            patient.DoctorGUI = this;
        }

        private void GridviewLoad(string doctor)
        {



        }

        private void waitingPatientGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void callPatient_Click(object sender, EventArgs e)
        {

            try
            {
                patientQueueManager.DequePatient(Doctor.DoctorId);
            }
            catch (Exception)
            {

                MessageBox.Show("No Data on Queue");
            }
         
            Doctor.LoadGridVIew(Doctor.DoctorId,waitingPatientGrid,patientQueueManager,patientManager);

            if (patientQueueManager.GetTopOfTheQueue(Doctor.DoctorId) != null)
            {
                QueueInfoLabel.Text = patientQueueManager.GetQueueByDoctor(Doctor).Count.ToString();
                QueueInfoLabel.Text = QueueInfoLabel.Text + "/" + patientQueueManager.GetTopOfTheQueue(Doctor.DoctorId).QueueNo;
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Doctor.LoadGridVIew(Doctor.DoctorId, waitingPatientGrid, patientQueueManager, patientManager);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (showPatientDetailButton.Text == "Show Patient Detail")
            {
                 waitingPatientGrid.Show();
                showPatientDetailButton.Text = "Hide Patient Detail";
            }
            else if (showPatientDetailButton.Text == "Hide Patient Detail")
            {
                showPatientDetailButton.Text = "Show Patient Detail";
                waitingPatientGrid.Hide();
            }
           

        }

       
    }
}
