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
    public partial class ExistingPatientForm : Form

    {
        PatientManager patientManager = new PatientManager();

        Patient patient = new Patient();

        public ExistingPatientForm()
        {
            InitializeComponent();
            searchPatientText.Text = "Search by patient id or name or phone";

        }

        private void ExistingPatientForm_Load(object sender, EventArgs e)
        {
            patient.patientGridLoad(viewPatientGrid);

            DataGridViewButtonColumn TakeButton = new DataGridViewButtonColumn();
            TakeButton.Text = "Take";
            TakeButton.UseColumnTextForButtonValue = true;
            viewPatientGrid.Columns.Add(TakeButton);
        }

        private void searchPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
     patient.Name = searchPatientText.Text;
           
            patient.searchPatientGridLoad(viewPatientGrid, patient.Name );

         
            }
            catch (Exception exception )
            {
                patient.patientGridLoad(viewPatientGrid);

               
            }
       
           
        }

       
           
        
        

        private void searchPatientText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void viewPatientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void viewPatientGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            if (e.ColumnIndex == 6)
            {
                //MessageBox.Show("");
                AssignDoctor assignDoctor = new AssignDoctor(patient);
                this.Close();
                assignDoctor.Show();
            }
        }
    }
}
