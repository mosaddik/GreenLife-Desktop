using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife1.BLL;
using greenlife1.UI;
using Greenlife1;

namespace greenlife1
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void showAllDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var doctorList = new DoctorList();
            doctorList.MdiParent = this;
            formManager.DisposeAllButThis(doctorList, this);
            doctorList.WindowState = FormWindowState.Maximized;
            doctorList.Show();
        }

        private void newDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var doctorRegistration = new DoctorRegisterForm();
            formManager.DisposeAllButThis(doctorRegistration, this);
            doctorRegistration.MdiParent = this;
            doctorRegistration.WindowState = FormWindowState.Maximized;
            doctorRegistration.Show();
        }
        FormManager formManager =  new FormManager();

        private void doctorHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var doctorLogin = new DoctorLoginForm();
            doctorLogin.MdiParent = this;
            formManager.DisposeAllButThis(doctorLogin, this);
            doctorLogin.WindowState = FormWindowState.Maximized;
            doctorLogin.Show();
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newPatient = new PatientRegisterForm();
            newPatient.MdiParent = this;
            formManager.DisposeAllButThis(newPatient, this);
            newPatient.WindowState = FormWindowState.Maximized;

            newPatient.Show();
        }

        private void allPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existingpatient = new ExistingPatientForm();
            existingpatient.MdiParent = this;

            formManager.DisposeAllButThis(existingpatient, this);
            existingpatient.WindowState = FormWindowState.Maximized;
            existingpatient.Show();
        }
    }
}
