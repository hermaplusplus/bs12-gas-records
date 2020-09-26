using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace bs12_gas_records
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        string recPublic, recMedical, recEmployment, recSecurity, recCourses;
        bool[] completed = new bool[7] { false, false, false, false, false, false, false };

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "")
                UpdateProgressBar(2, true);
            else
                UpdateProgressBar(2, false);
        }

        private void comboSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(3, true);
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (txtHeight.Text.Trim() != "")
                UpdateProgressBar(4, true);
            else
                UpdateProgressBar(4, false);
        }

        private void txtTrainingCentre_TextChanged(object sender, EventArgs e)
        {
            if (txtTrainingCentre.Text.Trim() != "")
                UpdateProgressBar(5, true);
            else
                UpdateProgressBar(5, false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text.Trim() != "")
            {
                if (checkPassed.Checked == true)
                {
                    if (txtCourseCode.Text.Trim() != "")
                        listCourses.Items.Add(txtCourseCode.Text + " " + txtCourseName + ", [i]passed[/i]");
                    else
                        listCourses.Items.Add(txtCourseName + ", [i]passed[/i]");
                }
                else
                {
                    if (txtCourseCode.Text.Trim() != "")
                        listCourses.Items.Add(txtCourseCode.Text + " " + txtCourseName + ", [i]failed[/i]");
                    else
                        listCourses.Items.Add(txtCourseName + ", [i]failed[/i]");
                }
                UpdateProgressBar(6, true);
            }
            else
                MessageBox.Show("Course name can't be empty!");
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listCourses.SelectedIndex != -1)
                listCourses.Items.RemoveAt(listCourses.SelectedIndex);
            if (listCourses.Items.Count == 0)
                UpdateProgressBar(6, false);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            while (listCourses.Items.Count != 0)
                listCourses.Items.RemoveAt(0);
            UpdateProgressBar(6, false);
        }

        private void comboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGrade.SelectedIndex >= 0 && comboGrade.SelectedIndex <= 2)
            {
                comboOccupation.Items.Clear();
                comboOccupation.Items.Add("Damage Control Technician");
                comboOccupation.Items.Add("Roboticist");
                comboOccupation.Items.Add("Chemist");
                comboOccupation.Items.Add("Paramedic/EMT");
                comboOccupation.SelectedIndex = 0;
                UpdateProgressBar(1, true);
            }
            else if (comboGrade.SelectedIndex >= 3 && comboGrade.SelectedIndex <= 5)
            {
                comboOccupation.Items.Clear();
                comboOccupation.Items.Add("Chef");
                comboOccupation.Items.Add("Bartender");
                comboOccupation.Items.Add("Deck Technician");
                comboOccupation.SelectedIndex = 0;
                UpdateProgressBar(1, true);
            }
            else if (comboGrade.SelectedIndex >= 6 && comboGrade.SelectedIndex <= 8)
            {
                comboOccupation.Items.Clear();
                comboOccupation.Items.Add("Janitor");
                comboOccupation.SelectedIndex = 0;
                UpdateProgressBar(1, true);
            }
            else
                comboOccupation.Items.Clear();
            UpdateProgressBar(0, true);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rng = new Random();
            if (rng.Next(0, 10) == rng.Next(0,10))
                this.Icon = new Icon("icons/cabbage.ico");
            else
                this.Icon = new Icon("icons/xynergy.ico");
        }

        private void UpdateProgressBar(int index, bool filled)
        {
            completed[index] = filled;
            int count = 0;
            for (int p = 0; p < 7; p++)
            {
                if (completed[p])
                    count++;
            }
            barProgress.Value = count * 10;
        }
    }
}
