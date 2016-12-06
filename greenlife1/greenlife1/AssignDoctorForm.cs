using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife1.BLL;

namespace greenlife1
{
    public partial class AssignDoctorForm : Form
    {
        public AssignDoctorForm()
        {
            InitializeComponent();
        }

        DoctorManager doctorManager =  new DoctorManager();
        private void AssignDoctorForm_Load(object sender, EventArgs e)
        {

            DataTable  dt  =  new DataTable();



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
        Queue<Patient> patientsQueue =  new Queue<Patient>();
       
        private void  assignGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string doctorId;
            if (e.ColumnIndex == 4)
            {
                //Patient patient =  new Patient();
                //patient
                //assignGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            
        }
    }
}
