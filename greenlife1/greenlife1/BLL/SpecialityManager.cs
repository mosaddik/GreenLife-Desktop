using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using greenlife1.DAL;

namespace greenlife1.BLL
{
    class SpecialityManager
    {
        SpecialityGetway specialityGetway  = new SpecialityGetway();
        public List<Speciality> GetAll()
        {
            return specialityGetway.GetAll();
        }

        public bool Save(Speciality speciality ,  string doctorid)
        {
            return specialityGetway.Save(speciality, doctorid);
        }
        
    }
}
