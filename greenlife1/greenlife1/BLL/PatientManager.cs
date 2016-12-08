using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife1.DAL;

namespace greenlife1.BLL
{
    public class PatientManager
    {

        private PatientGetaway patientGetaway =  new PatientGetaway();

        public bool Save(Patient patient)
        {
            return patientGetaway.Save(patient);
        }
        public Patient Get(Patient patient)
        {
            return    patientGetaway.GetById(patient);
        }

        public List<Patient> GetSearchedPatient(string searchTerm)
        {
            return patientGetaway.GetSearchedPatients(searchTerm);
        }
        public List<Patient> GetAll()
        {
            return patientGetaway.GetAll();
        }
       
 
    }
}
