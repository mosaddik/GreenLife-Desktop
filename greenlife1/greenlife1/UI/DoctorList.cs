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
    public partial class DoctorList : Form
    {

        DoctorManager doctorManager  =  new DoctorManager();
        SpecialityManager specialityManager =  new SpecialityManager();
        public DoctorList()
        {
            InitializeComponent();
        }

        private void doctorListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string[] arr = new string[10];
        ListViewItem itm;
        private void DoctorList_Load(object sender, EventArgs e)
        {
            doctorListView.View = View.Details;
            doctorListView.GridLines = true;
            doctorListView.FullRowSelect = true;

            //Add column header
            doctorListView.Columns.Add("Name",200);
            doctorListView.Columns.Add("DoctorId",100);
            doctorListView.Columns.Add("Doctor Email",150);
            doctorListView.Columns.Add("Age");
            doctorListView.Columns.Add("Spacialities",70);
            doctorListView.Columns.Add("Address",200);
            doctorListView.Columns.Add("Gender",50);
            doctorListView.Columns.Add("Phone",100);
            doctorListView.Columns.Add("Qualification",200);

           
            foreach (var doctor in    doctorManager.GetAllDoctor())
            {
                 string totalspaciality = "";
                arr[0] = doctor.Name;
                arr[1] = doctor.DoctorId;
                arr[2] = doctor.Email;
                arr[3] = Convert.ToString(doctor.GetDoctorAge());
                foreach (var spaciality  in  doctor.Speciality)
                {
                    totalspaciality = totalspaciality + spaciality.Name;
                }
                arr[4] = totalspaciality;
                arr[5] = doctor.Address;
                arr[6] = doctor.Gender;
                arr[7] =  doctor.Phone;
                arr[8] = doctor.Qualification;
                itm = new ListViewItem(arr);
                doctorListView.Items.Add(itm);
                
                
            }
           doctorListView.Dock = DockStyle.Fill;
            









        }

        private void doctorListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
            e.DrawText();
        }

        private void doctorListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

             e.DrawDefault = true;
    
        }
    }
}
