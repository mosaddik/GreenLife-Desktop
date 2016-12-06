using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Greenlife1;

namespace greenlife1
{
    public partial class DoctorHome : Form
    {
        public List<Doctor> QueueData { set; get; }
        public string doctor { set; get; }
        public DoctorHome()
        {
            InitializeComponent();
        }
        private void DoctorHome_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Problems", typeof(string));
            waitingPatientGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            

            foreach (var pQueue in QueueData)
            {
                if (pQueue.DoctorId == doctor)
                {

                    foreach (var patient in pQueue.PatientQueue)
                    {
                        table.Rows.Add(patient.Name, patient.Gender, patient.Problem);
                    }


          
                }
                waitingPatientGrid.DataSource = table;
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var patient  = new PatientRegisterForm();
            patient.DoctorGUI = this;
        }
    }
}
