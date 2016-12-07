using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife1
{
    class PatientQueue
    {
        public int Id { get; set; }
        public Doctor  Doctor { get; set; }
        public Patient Patient { get; set; }
        public string QueueNo { get; set; }
        public DateTime PatientEntryDateTime  { get; set; }

        public PatientQueue()
        {
            this.Doctor =  new Doctor();
            this.Patient = new Patient();
        }
    
    }
}
