using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Main.Forms
{
    public partial class FormMain : Form
    {
        public string Username, Role;

        private void buttonLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
            {
                panelExpand.Hide();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;

            if(Role == "User")
            {
                buttonDashboard.Hide();
                buttonAddClass.Hide();
                buttonAddStudent.Hide();
                buttonRegister.Hide();
            }
        }

        private void buttonMinimize_Click_1(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }
        private void timerDateAndTime_Tick_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void pictureBoxExpand_Click_1(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            {
                panelExpand.Visible = false;
            }
            else
            {
                panelExpand.Visible = true;
            }
        }

        private void buttonDashboard_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
        }

        private void buttonAttendance_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlDashboard1.Visible = false;
        }

        private void buttonAddClass_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
            userControlDashboard1.Visible = false;

        }

        private void buttonAddStudent_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
            userControlDashboard1.Visible = false;

        }

        private void buttonReport_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlDashboard1.Visible = false;

        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(buttonRegister);
            userControlDashboard1.Visible = false;

        }

        private void MoveSidePanel(Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }
    }
}
