using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    }
    
}
