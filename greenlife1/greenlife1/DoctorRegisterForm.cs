using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife1.BLL;

namespace greenlife1
{

    public partial class DoctorRegisterForm : Form
    {
        SpecialityManager specialityManager = new SpecialityManager();
        ScheduleManager scheduleManager =  new ScheduleManager();

        public DoctorRegisterForm()
        {
            InitializeComponent();
            CheckBox box;
            var i = 110;
            specialityManager.GetAll();

            foreach (var specility in specialityManager.GetAll())
            {
                var checkbox = new CheckBox();
                checkbox.Text = specility.Name;
                checkbox.Name = specility.ID.ToString();
                checkbox.AutoSize = true;
                checkbox.Location = new Point(i, 368); //vertical
                checkBoxs.Add(checkbox);
                doctorPanel.Controls.Add(checkbox);
                i = i + 50;
            }

            var day = new
            {
                Saturday = "Saturday",
                Sunday = "Sunday",
                Monday = "Monday",
                TuesDay = "Tuesday",
                WednesDay = "Wednesday",
                Thursday = "Thursday",
                Friday = "Friday"
            };
            var dayList =
                new[] { day.Saturday, day.Sunday, day.Monday, day.TuesDay, day.WednesDay, day.Thursday, day.Friday }
                    .ToList();
            dayComboBox.DataSource = dayList;

            startTime.Format = DateTimePickerFormat.Time;
            endTime.Format = DateTimePickerFormat.Time;
            startTime.ShowUpDown = true;
            endTime.ShowUpDown = true;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Day", 100);
            listView1.Columns.Add("StartTime", 70);
            listView1.Columns.Add("EndTime", 70);
           
        }

        List<CheckBox> checkBoxs = new List<CheckBox>();

        private void Form1_Load(object sender, EventArgs e)
        {
          














        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private Doctor doctor;
        private string doctorImage;
        private DoctorManager doctorManager = new DoctorManager();
        string docId = new Random().Next(1000, 2000).ToString();

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                doctor = new Doctor();
                doctor.DoctorId = docId;
                doctor.Name = nameTextBox.Text;
                doctor.Address = AddressTextBox.Text;
                doctor.NID = NIDTextBox.Text;
                doctor.Email = emailTextBox.Text;
                doctor.Phone = phoneBox.Text;
                doctor.Schedules = schedules;
                doctor.Image.Name = doctorImage;
                
                

                foreach (var checkbox in checkBoxs)
                {
                    if (checkbox.Checked)
                    {
                        var speciality = new Speciality();
                        speciality.ID = int.Parse(checkbox.Name);
                        doctor.Speciality.Add(speciality);
                    }
                }

                //get radio button 
                if (maleRadio.Checked)
                {
                    doctor.Gender = maleRadio.Text;
                }
                else if (femaleRadio.Checked)
                {
                    doctor.Gender = femaleRadio.Text;
                }

                // doctor.Speciality.Name = SpecilityTextBox.Text;
                doctor.DateOfBirth = doctorDatePicker.Value;
                doctor.Qualification = docotorQualificationBox.Text;




                if (doctorManager.Save(doctor))
                {
                    MessageBox.Show("Registation Successful");
                    nameTextBox.Text = "";
                    AddressTextBox.Text = "";
                    emailTextBox.Text = "";
                    maleRadio.Checked = false;
                    femaleRadio.Checked = false;
                    // SpecilityTextBox.Text = "";
                    imageTextBox.Text = String.Empty;
                    phoneTextBox.Text = String.Empty;
                    
                }
                else
                {
                    MessageBox.Show("Registration Not Compelte , please try again");
                }






            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }





        }

        private void docotorRegistrationLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            imageTextBox.Text = openFile.SafeFileName;
            doctorImage = openFile.SafeFileName;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private bool colRemoved = false;
        string[] arr = new string[4];
        ListViewItem itm;
        List<Schedule> schedules = new List<Schedule>();
        private void button2_Click(object sender, EventArgs e)
        {
           

            Schedule schedule = new Schedule();
            schedule.Day = dayComboBox.Text;
            schedule.FromTime =startTime.Value.TimeOfDay;
            schedule.ToTime = endTime.Value.TimeOfDay;
            schedule.Doctor.DoctorId = docId;
            


      

           

                
                //Add first item
                arr[0] = schedule.Day;
                arr[1] = schedule.FromTime.ToString();
                arr[2] = schedule.ToTime.ToString();
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
                schedules.Add(schedule);
            




        }

        private void doctorSheduleGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
