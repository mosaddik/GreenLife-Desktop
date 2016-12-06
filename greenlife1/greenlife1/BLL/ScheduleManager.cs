using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using greenlife1.DAL;

namespace greenlife1.BLL
{
    public class ScheduleManager
    {
        private ScheduleGetway scheduleGetway  =  new ScheduleGetway();

        public bool Save(Schedule schedule)
        {
            bool isSave = false;

            if (scheduleGetway.Save(schedule))
            {
                isSave = true;
            }
            return isSave;

        }



    }
}
