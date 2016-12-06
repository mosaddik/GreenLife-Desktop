using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greenlife1.UI
{
    public partial class AssignDoctor : Form
    {
        public  Patient Patient { get; set; }
        public AssignDoctor()
        {
            InitializeComponent();
        }

        public AssignDoctor(Patient patient)
        {
            InitializeComponent();
            this.Patient = patient;

        }

        private void AssignDoctor_Load(object sender, EventArgs e)
        {
            patientNameLabel.Text = this.Patient.Name;
            patientPhoneLabel.Text = this.Patient.Phone;
            patientProblemLabel.Text = this.Patient.Problem;
            Patient.GridviewLoad(dataGridView1);
        }
    }
}
