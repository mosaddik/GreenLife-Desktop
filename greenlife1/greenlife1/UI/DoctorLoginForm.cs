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

namespace greenlife1.UI
{
    public partial class DoctorLoginForm : Form
    {
        DoctorManager doctorManager =  new DoctorManager();
        PatientQueueManager patientQueueManager =  new PatientQueueManager();
        public DoctorLoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

          

            Doctor doctor =  new Doctor();
            doctor.DoctorId = nameBox.Text;
            doctor.Password = passwordBox.Text;

            if (doctorManager.Login(doctor))
            {
                 var loginedDoctor = doctorManager.GetById(doctor);
                 DoctorHome doctorHome =  new DoctorHome(loginedDoctor.DoctorId);
                 this.Close();
                 doctorHome.Show();
            }

        }

        private void DoctorLoginForm_Load(object sender, EventArgs e)
        {

        }

    
    }
}
