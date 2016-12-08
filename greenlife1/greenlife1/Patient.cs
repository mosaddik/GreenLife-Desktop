using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife1.BLL;

namespace greenlife1
{
   public class Patient
    {
        public int ID { get; set; }
        public string PatientId { set; get; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public Image Image { set; get; }

        public DateTime DOB { get; set; }

        public string NID { get; set; }

        public string Address { get; set; }

        public string  Problem { get; set; }

        public string Phone { set; get; }

        public List<Schedule> Schedules { get; set; }

        public Doctor Doctor { get; set; }

        public Patient()
        {
            this.Image = new Image();
         
            this.Schedules = new List<Schedule>();
            this.Doctor = new Doctor();
        }

        public void GridviewLoad(DataGridView assignGrid)
        {
              DataTable  dt  =  new DataTable();
              DoctorManager doctorManager =  new DoctorManager();


            dt.Columns.Add("Doctor Id", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Qualification", typeof(string));
            dt.Columns.Add("Speciality", typeof(string));
            foreach (var doctor in doctorManager.GetAllDoctor())
            {
                if (doctor.Name != "")
                {


                    string specli = "";
                    if (doctor.Speciality != null)
                    {
                        foreach (var speciality in doctor.Speciality)
                        {
                            specli = specli + " " + speciality.Name;
                        }
                    }

                    assignGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dt.Rows.Add(doctor.DoctorId,doctor.Name, doctor.Qualification, specli);

                    assignGrid.DataSource = dt;
                  


                }
              
            }
            DataGridViewButtonColumn assignButton = new DataGridViewButtonColumn();
            assignButton.Text = "Assign";
            assignButton.UseColumnTextForButtonValue = true;
            assignGrid.Columns.Add(assignButton);

        }

        public void patientGridLoad(DataGridView viewPatientGrid)

        {
            DataTable dt = new DataTable();
            PatientManager patientManager = new PatientManager();
            //Patient pat = new Patient();

        
            
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Problems", typeof(string));
            dt.Columns.Add("Natitonal ID", typeof(string));
            
            foreach (var patient in patientManager.GetAll())
            {
                  //  if(pa)
                    
                    viewPatientGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dt.Rows.Add(patient.Name,patient.Gender,patient.Phone,patient.Address,patient.Problem,patient.NID);
                //);

            }
            viewPatientGrid.DataSource = dt;

            }



        public void searchPatientGridLoad(DataGridView viewPatientGrid, string search)
        {
            DataTable dt = new DataTable();
            PatientManager patientManager = new PatientManager();
            //Patient pat = new Patient();



            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Phone", typeof(string));

            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Problems", typeof(string));
            dt.Columns.Add("Natitonal ID", typeof(string));

            foreach (var patient in patientManager.GetSearchedPatient(search))
            {
                //  if(pa)

                viewPatientGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dt.Rows.Add(patient.Name, patient.Gender, patient.Phone, patient.Address, patient.Problem, patient.NID);
                //);

            }
            viewPatientGrid.DataSource = dt;

        }

    }
}
