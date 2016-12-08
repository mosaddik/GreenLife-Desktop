using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace greenlife1.DAL
{
    public class DoctorGetaway
    {
        private string connectionString = "Data Source=192.168.0.103,49170;Initial Catalog=greenlife;User=sa; Password=123;";


        public bool Save(Doctor doctor)
        {
            bool isSave = false;

            SqlConnection connection =  new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO dbo.doctor ([doctor_id],name,gender,address,phone,nid,qualification,image,[date_of_birth],email,password)" +
                           "values('"+doctor.DoctorId+"','"+doctor.Name+"','"+doctor.Gender+"','"+doctor.Address+"','"+doctor.Phone+"','"+doctor.NID+"','"+doctor.Qualification+"','"+doctor.Image.Name
                           +"','"+doctor.DateOfBirth+"','"+doctor.Email+"' , '"+doctor.Password +"')";
   
            ;
            SqlCommand command = new SqlCommand(query,connection);
            int rowsEffected = command.ExecuteNonQuery();
            
            if (rowsEffected > 0)
            {
                isSave = true;
            }
            connection.Close();
            return isSave;
        }
        public Doctor GetById(Doctor doctor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select * from doctor where doctor_Id='"+doctor.DoctorId+"'";
            SqlCommand command =  new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();
            Doctor doc = null; 
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    doc =  new Doctor();
                    doc.ID = Convert.ToInt32(reader["Id"]);
                    doc.DoctorId = Convert.ToString(reader["doctor_Id"]);
                    doc.Address = Convert.ToString(reader["address"]);
                    doc.Phone = Convert.ToString(reader["phone"]);
                    doc.NID = Convert.ToString(reader["nid"]);
                    doc.DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]);
                    doc.Email = Convert.ToString(reader["email"]);
                    doc.Image.Name = Convert.ToString(reader["image"]);
                    doc.Password = Convert.ToString(reader["password"]);
                    

                }
                
            }
            
            connection.Close();
            return doc;

        }
        public List<Doctor> GetAllDoctor()
        {

          SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            var doctorList  =  new List<Doctor>();
            string qurey = "Select * from doctor";
            SqlCommand command =  new SqlCommand(qurey,connection);
            SqlDataReader reader = command.ExecuteReader();
            Doctor doc = null; 
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    doc =  new Doctor();
                    doc.ID = Convert.ToInt32(reader["Id"]);
                    doc.Name = reader["name"].ToString();
                    doc.DoctorId = Convert.ToString(reader["doctor_Id"]);
                    doc.Address = Convert.ToString(reader["address"]);
                    doc.Phone = Convert.ToString(reader["phone"]);
                    doc.NID = Convert.ToString(reader["nid"]);
                    doc.DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]);
                    doc.Email = Convert.ToString(reader["email"]);
                    doc.Qualification = Convert.ToString(reader["qualification"]);
                    doc.Image.Name = Convert.ToString(reader["image"]);
                    doc.Password = Convert.ToString(reader["password"]);
                    doctorList.Add(doc);
                }
                
            }
      
            connection.Close();
            return doctorList;

        }
        }

    }

