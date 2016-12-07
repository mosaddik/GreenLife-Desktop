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
        Patient patient = new Patient();
        public ExistingPatientForm()
        {
            InitializeComponent();
        }

        private void ExistingPatientForm_Load(object sender, EventArgs e)
        {
       

            



          
            patient.patientViewLoad(viewPatientGrid);
        }
    }
}
