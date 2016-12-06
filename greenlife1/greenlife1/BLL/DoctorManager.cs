using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife1.DAL;

namespace greenlife1.BLL
{
    class DoctorManager

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
        
       
    }
}
