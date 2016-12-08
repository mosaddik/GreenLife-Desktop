using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greenlife1;

namespace greenlife1.DAL
{
    public class PatientGetaway
    {
        private string connectionString = "Data Source=192.168.0.103,49170;Initial Catalog=greenlife;User=sa; Password=123;";


        public bool Save(Patient patient)
        {
            bool isSave = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO patient (patient_Id,name,gender,address,phone,nid,image,date_Of_Birth,problems)" +
                           "values('" + patient.PatientId + "','" + patient.Name + "','" + patient.Gender + "','" + patient.Address + "','" + patient.Phone + "','" + patient.NID + "','" + patient.Image + "','" + patient.DOB
                           + "','"+patient.Problem+"')";

            SqlCommand command = new SqlCommand(query, connection);
            int rowsEffected = command.ExecuteNonQuery();

            if (rowsEffected > 0)
            {
                isSave = true;
            }
            connection.Close();
            return isSave;
        }
        public Patient GetById(Patient patient)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select * from patient where patient_id='" + patient.PatientId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            Patient pat = null;
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    pat = new Patient();
                    pat.ID = Convert.ToInt32(reader["id"]);
                    pat.PatientId = Convert.ToString(reader["patient_id"]);
                    pat.Name = Convert.ToString(reader["name"]);
                    pat.Phone = Convert.ToString(reader["phone"]);
                    pat.Email = Convert.ToString(reader["email"]);
                    pat.DOB = Convert.ToDateTime(reader["date_of_birth"]);
                    pat.Gender = Convert.ToString(reader["gender"]);
                    pat.Problem = Convert.ToString(reader["problems"]);
                    pat.Address = Convert.ToString(reader["address"]);
                    pat.NID = Convert.ToString(reader["NID"]);
                    pat.Image.Name = Convert.ToString(reader["image"]);
                }

            }

            connection.Close();
            return pat;

        }
        public List<Patient> GetAll()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            var patientList = new List<Patient>();
            string qurey = "select * from patient";
            SqlCommand command = new SqlCommand(qurey, connection);
            SqlDataReader reader = command.ExecuteReader();
            Patient pat = null;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pat = new Patient();
                    pat.ID = Convert.ToInt32(reader["id"]);
                    pat.PatientId = Convert.ToString(reader["patient_id"]);
                    pat.Name = Convert.ToString(reader["name"]);
                    pat.Phone = Convert.ToString(reader["phone"]);
                    pat.Email = Convert.ToString(reader["email"]);
                    pat.DOB = Convert.ToDateTime(reader["date_of_birth"]);
                    pat.Gender = Convert.ToString(reader["gender"]);
                    pat.Problem = Convert.ToString(reader["problems"]);
                    pat.Address = Convert.ToString(reader["address"]);
                    pat.NID = Convert.ToString(reader["NID"]);
                    pat.Image.Name = Convert.ToString(reader["image"]);
                }

            }

            connection.Close();
            return patientList;

        }
    }
}
