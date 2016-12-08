using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife1.DAL
{
    public class QueueGetaway
    {
        private string connectionString =
            "Data Source=192.168.0.103,49170;Initial Catalog=greenlife;User=sa; Password=123;";



        public bool Save(PatientQueue queue)
        {
            bool isSave = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO [Patient_Queue]  (doctor_id,patient_id,queue_no,date,state) values ('" +
                           queue.Doctor.DoctorId + "','" + queue.Patient.PatientId + "','" + queue.QueueNo + "','" +
                           queue.PatientEntryDateTime.Date.ToString("dd-MM-yyyy") + "','"+queue.State+"') ";
            ;
            SqlCommand command = new SqlCommand(query, connection);
            int rowsEffected = command.ExecuteNonQuery();

            if (rowsEffected > 0)
            {
                isSave = true;
            }
            connection.Close();
            return isSave;
        }

        public List<PatientQueue> GetByDcotorId(Doctor doctor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select * from [Patient_Queue] where doctor_Id='" + doctor.DoctorId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            List<PatientQueue> patientQueues = new List<PatientQueue>();
            SqlDataReader reader = command.ExecuteReader();
            Doctor doc = null;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    PatientQueue patientQueue = new PatientQueue();
                    patientQueue.Doctor.DoctorId = reader["doctor_id"].ToString();
                    patientQueue.Patient.PatientId = reader["patient_id"].ToString();
                    patientQueue.QueueNo = reader["queue_no"].ToString();
                    patientQueue.PatientEntryDateTime = Convert.ToDateTime(reader["date"]);
                    
                    patientQueues.Add(patientQueue);
                }

            }

            connection.Close();
            return patientQueues;

        }

        public List<PatientQueue> GetAll()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select * from [Patient_Queue] ";
            SqlCommand command = new SqlCommand(query, connection);
            List<PatientQueue> patientQueues = new List<PatientQueue>();
            SqlDataReader reader = command.ExecuteReader();
            Doctor doc = null;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    PatientQueue patientQueue = new PatientQueue();
                    patientQueue.Doctor.DoctorId = reader["doctor_id"].ToString();
                    patientQueue.Patient.PatientId = reader["patient_id"].ToString();
                    patientQueue.QueueNo = reader["queue_no"].ToString();
                    patientQueue.PatientEntryDateTime = Convert.ToDateTime(reader["date"]);
                    patientQueues.Add(patientQueue);
                }

            }

            connection.Close();
            return patientQueues;

        }

        public List<PatientQueue> GetTodayQueues()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select * from [Patient_Queue] where date BETWEEN '" + DateTime.Today.ToString("dd-MM-yyyy") +
                           "' AND  '" + DateTime.Today.AddDays(1).AddSeconds(-1).ToString("dd-MM-yyyy") + "'  AND state= 'INQUEUE' ";
            SqlCommand command = new SqlCommand(query, connection);
            List<PatientQueue> patientQueues = new List<PatientQueue>();
            SqlDataReader reader = command.ExecuteReader();
            Doctor doc = null;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    PatientQueue patientQueue = new PatientQueue();
                    patientQueue.Doctor.DoctorId = reader["doctor_id"].ToString();
                    patientQueue.Patient.PatientId = reader["patient_id"].ToString();
                    patientQueue.QueueNo = reader["queue_no"].ToString();
                    patientQueue.PatientEntryDateTime = Convert.ToDateTime(reader["date"]);
                    patientQueue.State = reader["state"].ToString();
                    patientQueues.Add(patientQueue);
                    
                }

            }

            connection.Close();
            return patientQueues;
        }

        public PatientQueue GetMaxQueueNoOfToDayOfADocotor(string doctorId)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "select MAX(queue_no) from [Patient_Queue] where date BETWEEN '" +
                               DateTime.Today.ToString("dd-MM-yyyy") + "' AND  '" +
                               DateTime.Today.AddDays(1).AddSeconds(-1).ToString("dd-MM-yyyy") + "' AND doctor_id='" + doctorId + "' AND state='INQUEUE'";
                SqlCommand command = new SqlCommand(query, connection);

                PatientQueue patientQueue = null;

                if (command.ExecuteScalar() != null)
                {
                patientQueue = new PatientQueue();
                patientQueue.QueueNo = command.ExecuteScalar().ToString(); 
                }
         

                connection.Close();
                return patientQueue;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Deque(PatientQueue patientQueue)
        {
            bool isSave = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE [Patient_Queue] SET state='DEQUE' where patient_id='" + patientQueue.Patient.PatientId + "'   ";
            ;
            SqlCommand command = new SqlCommand(query, connection);
            int rowsEffected = command.ExecuteNonQuery();

            if (rowsEffected > 0)
            {
                isSave = true;
            }
            connection.Close();
            return isSave;
        }


       




    }
}
