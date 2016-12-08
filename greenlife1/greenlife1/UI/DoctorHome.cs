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
        DoctorManager doctorManager =  new DoctorManager();
        PatientManager patientManager =  new PatientManager();
        PatientQueueManager patientQueueManager =  new PatientQueueManager();
        public List<Doctor> DoctorWithpatientQueue { set; get; }
        public string DoctorId { set; get; }
        public DoctorHome(string doctor)
        {
            
            InitializeComponent();
            GridviewLoad(doctor);
            this.Doctor = new Doctor(doctor);
            Doctor.LoadGridVIew(Doctor.DoctorId, waitingPatientGrid, patientQueueManager, patientManager);





        }
        private void DoctorHome_Load(object sender, EventArgs e)
        {
           
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var patient  = new PatientRegisterForm();
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
            
            var patient = patientQueueManager.DequePatient(Doctor.DoctorId);
            PatientNameLabel.Text = patient.Name;
            Doctor.LoadGridVIew(Doctor.DoctorId,waitingPatientGrid,patientQueueManager,patientManager);

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Doctor.LoadGridVIew(Doctor.DoctorId, waitingPatientGrid, patientQueueManager, patientManager);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Doctor  doc = doctorManager.GetById(Doctor);
            doc.GetDoctorAge();
        }

       
    }
}
