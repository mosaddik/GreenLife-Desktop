﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using greenlife1.DAL;

namespace greenlife1.BLL
{
    public class PatientQueueManager
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

        public string GenarateQueueNo(string docotorId)
        {

            PatientQueue patientQueue = new PatientQueue() {QueueNo = "1"};

            string queueNo = patientQueue.QueueNo;

            if (queueGetaway.GetMaxQueueNoOfToDayOfADocotor(docotorId).QueueNo != "")
            {
                patientQueue = queueGetaway.GetMaxQueueNoOfToDayOfADocotor(docotorId);
                queueNo = (Convert.ToInt32(patientQueue.QueueNo) + 1).ToString();
            }


            return queueNo;


        }

        PatientGetaway patientGetaway = new PatientGetaway();

        public Patient DequePatient(string docotorId)
        {
            try
            {
                var queue = this.GetTodayQueueByDoctor(docotorId).First();
                var patient = patientGetaway.GetById(queue.Patient);
                queueGetaway.Deque(queue);
                return patient;
            }
            catch (Exception)
            {

                return null;
            }
            return null;

        }

        public PatientQueue GetTopOfTheQueue(string docotorId)
        {
            PatientQueue queue = null;
            try
            {
                queue = this.GetTodayQueueByDoctor(docotorId).First();
            }
            catch (Exception)
            {

                return  null;
            }
            return queue;

        }

    }
}
