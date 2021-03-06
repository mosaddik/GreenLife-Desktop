﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife1.BLL;
using greenlife1;
using greenlife1.UI;
using Spire.Barcode;
using Spire.Barcode.Forms;
using Image = System.Drawing.Image;


namespace Greenlife1
{
    public partial class PatientRegisterForm : Form
    {

        private PatientManager patientManager = new PatientManager();
        private DoctorManager doctorManager = new DoctorManager();
        private Patient patient;
        private string imageName;
        public DoctorHome DoctorGUI { set; get; }

        public PatientRegisterForm()
        {
            InitializeComponent();
        }

        private void PatientRegisterForm_Load(object sender, EventArgs e)
        {



        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                patient = new Patient();
                patient.Name = nameTextBox.Text;
                patient.PatientId = new Random().Next(10000, 900000).ToString();
                patient.Address = addressTextBox.Text;
                patient.NID = NIDTextBox.Text;
                patient.DOB = patientDatePicker.Value;
                patient.Problem = problemRichTextBox.Text;
                patient.Phone = phoneTextBox.Text;
                patient.Image.Name = imageName;

                if (maleRadio.Checked)
                {
                    patient.Gender = maleRadio.Text;
                }
                else if (femaleRadio.Checked)
                {
                    patient.Gender = femaleRadio.Text;
                }

                if (patientManager.Save(patient))
                {
                    DialogResult dialogResult = MessageBox.Show("Do You want to Print an Id Card", "CONF",
                        MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {

                        PrintDocument printDocument = new PrintDocument();
                        printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                        CaptureScreen();
                        printDocument.Print();
                        AssignDoctor assignDoctor = new AssignDoctor(patient);
                        MessageBox.Show("Registation Successfull , Please Assign to Doctor Now");
                        this.Close();
                        assignDoctor.Show();
                      



                    }
                    if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Registation Successfull , Please Assign to Doctor Now");
                        AssignDoctor assignDoctor = new AssignDoctor(patient);
                        this.Close();
                        assignDoctor.Show();
                    }
                    nameTextBox.Text = "";
                    addressTextBox.Text = "";
                    NIDTextBox.Text = "";
                    emailTextBox.Text = "";
                    maleRadio.Checked = false;
                    femaleRadio.Checked = false;
                    problemRichTextBox.Text = "";
                    phoneTextBox.Text = "";
                    imageTextBox.Text = String.Empty;


                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            imageTextBox.Text = openFile.SafeFileName;
             imageName = openFile.FileName;


        }

        private void imageTextBox_TextChanged(object sender, EventArgs e)
        {

        }




        private void printDocument1_PrintPage(System.Object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            int startX = 100;
            int startY = 100;
            //e.Graphics.DrawImage(memoryImage, 0, 0);
            e.Graphics.DrawString(" Test print", new Font("Courier New", 18), new SolidBrush(Color.Black), startX,
                startY);
            Point loc = new Point(200, 200);


            BarCodeGenerator generator = new BarCodeGenerator(new Idcardobj("mosaddik").QRCODE());
            Image image = new Bitmap(generator.GenerateImage(), 150, 150);



            e.Graphics.DrawImage(image, loc);

        }

        private void CaptureScreen()
        {


            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            // memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            //Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            //memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

        }

        private Doctor doctor;
        private string checkDocid = " ";
        private string checkPatid = " ";


        public static List<Doctor> doctorList = new List<Doctor>();

        private void assignGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            ////adding to Queue 
            //if (e.ColumnIndex == 0)
            //{


            //      // string doctorid  =  assignGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

            //    if (doctorid != checkDocid)
            //    {

            //        {
            //            doctor = new Doctor(doctorid);
            //            checkDocid = doctorid;
            //            doctor.PushPatient(patient);
            //            doctorList.Add(doctor);
            //        }
            //    }
            //    else
            //    {
            //        doctor.PushPatient(patient);
            //        doctorList.Where(d => d.DoctorId == checkDocid).First().PatientQueue = doctor.PatientQueue;
            //    }


        }

        
        private void AssignDoctorButton_Click(object sender, EventArgs e)
        {
            if (patient != null)
            {
                AssignDoctor assignDoctor = new AssignDoctor(patient);
                assignDoctor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Register");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }









}



