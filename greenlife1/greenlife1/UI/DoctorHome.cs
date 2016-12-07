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
        DoctorManager doctorManager =  new DoctorManager();
        PatientManager patientManager =  new PatientManager();
        PatientQueueManager patientQueueManager =  new PatientQueueManager();
        public List<Doctor> DoctorWithpatientQueue { set; get; }
        public string DoctorId { set; get; }
        public DoctorHome(string doctor)
        {

            InitializeComponent();
            var docotorQueue = patientQueueManager.GetTodayQueueByDoctor(doctor);
           // Doctor newDoctor  =  new Doctor(doctor);
             DataTable table =  new DataTable();
            table.Columns.Add("Serail No",typeof(string));
            table.Columns.Add("Patient Name",typeof(string));
            table.Columns.Add("Patient Problem",typeof(string));

            foreach (var docQueue in docotorQueue)
            {
                //patientManager.Get(new )
                
            }
     






        }
        private void DoctorHome_Load(object sender, EventArgs e)
        {
           
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var patient  = new PatientRegisterForm();
            patient.DoctorGUI = this;
        }
    }
}
