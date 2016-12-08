using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife1.BLL;


namespace greenlife1
{
    public class Doctor
    {
        public int ID { set; get; }
        public String Name { set; get; }
        public String Password { set; get; }
        public string DoctorId { set; get; }
        public Image Image { set; get; }
        public String Gender { set; get; }
        public String Email { set; get; }
        public string NID { set; get;  }
        public string Phone { set; get; }

        public string Qualification { set; get ; }
        public DateTime DateOfBirth { set; get; }
        public string Address { set; get; }

        public List<Schedule> Schedules { set; get; }
        public List<Speciality> Speciality {set; get ;}
        public Queue<Patient> PatientQueue { get; set; }

        public Doctor()
        {
            this.Image =  new Image();
            this.Speciality = new List<Speciality>();
            this.PatientQueue = new Queue<Patient>();
        }

        public Doctor(string doctorId):this()
        {
            this.DoctorId = doctorId;
        }

        public void PushPatient(Patient patient)
        {
            this.PatientQueue.Enqueue(patient);
        }

        public void PopPatient()
        {
            this.PatientQueue.Dequeue();
        }

        public int GetDoctorAge()
        {
            int age =   (DateTime.Now.Year - DateOfBirth.Year);
            return age;
        }


        public void LoadGridVIew(string doctor, DataGridView waitingPatientGrid,PatientQueueManager patientQueueManager,PatientManager patientManager )
        {
          
            DataTable table = new DataTable();
            table.Columns.Add("Serail No", typeof(string));
            table.Columns.Add("Patient Name", typeof(string));
            table.Columns.Add("Patient Problem", typeof(string));
            var docotorQueue = patientQueueManager.GetTodayQueueByDoctor(doctor);
            foreach (var docQueue in docotorQueue)
            {
                var patient = patientManager.Get(docQueue.Patient);
                table.Rows.Add(docQueue.QueueNo, patient.Name, patient.Problem);
            }
            waitingPatientGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            waitingPatientGrid.DataSource = table;
        }
    }
    
}
