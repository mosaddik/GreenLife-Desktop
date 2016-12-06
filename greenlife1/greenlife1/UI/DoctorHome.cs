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
using Greenlife1;

namespace greenlife1
{
    
    public partial class DoctorHome : Form
    {
        DoctorManager doctorManager =  new DoctorManager();
        public List<Doctor> DoctorWithpatientQueue { set; get; }
        public string DoctorId { set; get; }
        public DoctorHome( List<Doctor> doctorWithpatientQueue , string doctorId )
        {
            InitializeComponent();
            this.DoctorWithpatientQueue = doctorWithpatientQueue;
            this.DoctorId = doctorId;
            doctorManager.ViewPatientQueue(waitingPatientGrid, doctorWithpatientQueue, doctorId);
        }
        private void DoctorHome_Load(object sender, EventArgs e)
        {
           
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var patient  = new PatientRegisterForm();
            patient.DoctorGUI = this;
        }
    }
}
