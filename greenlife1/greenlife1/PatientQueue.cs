﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife1
{
    class PatientQueue
    {
        public int Id { get; set; }
        public string  DoctorId { get; set; }
        public string PatientId { get; set; }
        public string QueueNo { get; set; }
        public DateTime PatientEntryDateTime  { get; set; }
    }
}
