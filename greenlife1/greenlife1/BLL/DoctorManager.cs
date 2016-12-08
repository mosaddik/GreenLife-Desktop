using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife1.DAL;

namespace greenlife1.BLL
{
    public class DoctorManager

    {
        private DoctorGetaway doctorGetaway =   new DoctorGetaway();
        SpecialityGetway specialityGetway = new SpecialityGetway();
        ScheduleGetway scheduleGetway =  new ScheduleGetway();
        SpecialityManager specialityManager =  new SpecialityManager();

        public bool Save(Doctor doctor)
        {

            foreach (var speciality in doctor.Speciality)
            {
                specialityManager.Save(speciality,doctor.DoctorId);
            }


            foreach (var schedules in doctor.Schedules)
            {
                scheduleGetway.Save(schedules);
            }
            return doctorGetaway.Save(doctor);
        }
        public Doctor GetById(Doctor doctor)
        {
            return doctorGetaway.GetById(doctor);
        }
        public List<Doctor> GetAllDoctor()
        {
            var docList =  new List<Doctor>();
            foreach (var doctor in  doctorGetaway.GetAllDoctor())
            {
                var doc =  new Doctor();
                doc = doctor;
                int spec = specialityGetway.GetIdByDoctor(doc);
                doc.Speciality = specialityGetway.GetById(spec);
                docList.Add(doc);

            }
           return docList;








        }

        public void ViewPatientQueue(DataGridView waitingPatientGrid , List<Doctor> doctorWithPatientQueue , string doctorId)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Problems", typeof(string));
            waitingPatientGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            foreach (var pQueue in doctorWithPatientQueue)
            {
                if (pQueue.DoctorId == doctorId)
                {

                    foreach (var patient in pQueue.PatientQueue)
                    {
                        table.Rows.Add(patient.Name, patient.Gender, patient.Problem);
                    }
                }
                waitingPatientGrid.DataSource = table;
            }
        }

        public bool Login(Doctor newDoctor)
        {
            bool isLogin = false;

            foreach (var doctor in doctorGetaway.GetAllDoctor())
            {
                if (doctor.DoctorId !=null && doctor.Password != null && doctor.DoctorId == newDoctor.DoctorId && doctor.Password == newDoctor.Password)
                {
                    isLogin = true;
                }
                
            }
            

            return isLogin;
        }
        
       
    }
}
