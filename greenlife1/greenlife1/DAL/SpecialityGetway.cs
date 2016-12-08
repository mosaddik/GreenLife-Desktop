using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife1.DAL
{
   public  class SpecialityGetway
    {


        private string connectionString = "Data Source=192.168.0.103,49170;Initial Catalog=greenlife;User=sa; Password=123;";

        public bool Save(Speciality speciality , string doctorId)
        {


            bool isSave = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO doctor_specialization(doctor_id,specialize_id)" +
                           "values('" + doctorId + "','"+speciality.ID+"')";

            SqlCommand command = new SqlCommand(query, connection);
            int rowsEffected = command.ExecuteNonQuery();

            if (rowsEffected > 0)
            {
                isSave = true;
            }
            connection.Close();
            return isSave;

        }
        public List<Speciality> GetAll()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string qurey = "select * from Specialize";
            List<Speciality> specialities =  new List<Speciality>();
            SqlCommand command = new SqlCommand(qurey, connection);
            SqlDataReader reader = command.ExecuteReader();
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var speciality = new Speciality();
                    speciality.Name = reader["name"].ToString();
                    speciality.ID = Convert.ToInt32(reader["id"]);
                    specialities.Add(speciality);
                }

            }

            connection.Close();
            return specialities;

        }
        public int GetIdByDoctor(Doctor doctor)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select * from [doctor_specialization] where [doctor_id] = '" + doctor.DoctorId + "'";
            
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            var speciality = new Speciality();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    speciality.ID = Convert.ToInt32(reader["specialize_id"]);        
                }

            }

            connection.Close();
            return speciality.ID;

        }
        public List<Speciality> GetById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select * from [Specialize] where id = '" + id + "'";
            List<Speciality> specialities =  new List<Speciality>();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
         

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var spec = new Speciality();
                    spec.Name = reader["name"].ToString();
                    spec.ID = Convert.ToInt32(reader["id"]);

                    specialities.Add(spec);
                }

            }

            connection.Close();
            return specialities;
            
        }





       

    }

}
