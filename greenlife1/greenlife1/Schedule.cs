using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife1
{
   public  class Schedule
    {
        public int  Id { get; set; }
        public string   Day { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan  ToTime  { get; set; }

        public Doctor Doctor { get; set; }


        public Schedule()
        {
            this.Doctor =  new Doctor();

        }
    }

  
}
