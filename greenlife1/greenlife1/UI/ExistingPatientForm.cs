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

namespace greenlife1.UI
{
    public partial class 
         
        ExistingPatientForm : Form

    {
        PatientManager patientManager = new PatientManager();

        public Patient Patient { get; set; }

        public ExistingPatientForm()
        {
            InitializeComponent();
            searchPatientText.Text = "Search by patient id or name or phone";

        }

        private void ExistingPatientForm_Load(object sender, EventArgs e)
        {
            this.Patient = new Patient();
            Patient.patientGridLoad(viewPatientGrid);

            DataGridViewButtonColumn TakeButton = new DataGridViewButtonColumn();
            TakeButton.Text = "Take";
            TakeButton.UseColumnTextForButtonValue = true;
            viewPatientGrid.Columns.Add(TakeButton);

        }

        private void searchPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                Patient.Name = searchPatientText.Text;

                Patient.searchPatientGridLoad(viewPatientGrid, Patient.Name);

         
            }
            catch (Exception exception )
            {
                Patient.patientGridLoad(viewPatientGrid);

               
            }
       
           
        }

       
           
        
        

        private void searchPatientText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void viewPatientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        PatientQueueManager patientQueueManager =  new PatientQueueManager();
        private void viewPatientGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //goto  assing doctor 
            if (e.ColumnIndex == 7)
            {
              

                string patientId = viewPatientGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                //if this patient already assiged to a doctor 
                foreach (var queue in  patientQueueManager.GetToDayQueue())
                {
                    if (queue.Patient.PatientId == patientId)
                    {
                        MessageBox.Show("Already  assined to  a doctor");
                        return;
                    }

                }
               

                Patient = patientManager.Get(new Patient() {PatientId = patientId}); 
               AssignDoctor assignDoctor = new AssignDoctor(Patient);
                this.Close();
                assignDoctor.Show();
            }
        }
    }
}
