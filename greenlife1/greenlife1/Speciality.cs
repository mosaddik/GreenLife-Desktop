using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife1
{
    public class Speciality
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public List<Doctor> Doctors { set; get; }

        public Speciality()
        {
            this.Doctors =  new List<Doctor>();
        }
    }
}
