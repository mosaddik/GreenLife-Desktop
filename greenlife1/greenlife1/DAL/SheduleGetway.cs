using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife1.DAL
{
    class ScheduleGetway
    {
        string connectionString = "Server=MOSADDIK-PC\\SQLEXPRESS;Database=greenlife;Integrated Security=true";

        public bool Save(Schedule schedule)
        {
            bool isSave = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Schedule(day,start_time,end_time,doctor_id)" +
                           "values('" + schedule.Day + "','" + schedule.FromTime + "','" + schedule.ToTime + "','"+schedule.Doctor.DoctorId+"')";

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
