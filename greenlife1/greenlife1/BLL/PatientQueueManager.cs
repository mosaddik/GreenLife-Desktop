﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using greenlife1.DAL;

namespace greenlife1.BLL
{
    class PatientQueueManager
    {
        private QueueGetaway queueGetaway = new QueueGetaway();

        public bool AddToQueue(PatientQueue queue)
        {
            return queueGetaway.Save(queue);
        }

        public List<PatientQueue> GetQueueByDoctor(Doctor doctor)
        {
            return queueGetaway.GetByDcotorId(doctor);
        }

        public List<PatientQueue> GetToDayQueue()
        {
            var list = queueGetaway.GetTodayQueues();
            return list;
        }

        public List<PatientQueue> GetTodayQueueByDoctor(string doctorId)
        {
            var list = queueGetaway.GetTodayQueues().Where(queue => queue.Doctor.DoctorId == doctorId).ToList();
            return list;
        }

        public string GenarateQueueNo()
        {
            PatientQueue patientQueue = queueGetaway.GetMaxQueueNoOfToDay();
           string patientQueueno =  (Convert.ToInt32(patientQueue.QueueNo) + 1).ToString();
            
            if (queueGetaway.GetMaxQueueNoOfToDay() == null)
            {

                patientQueueno = "1";
            }
            
            return patientQueueno;   
        }

    }
}