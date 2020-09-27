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
using System.IO;

namespace bs12_gas_records
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        string recPublic, recMedical, recEmployment, recSecurity, recCourses;
        string[] recTemperaments = new string[3];
        bool[] completed = new bool[10] { false, false, false, false, false, false, false, false, false, false };

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "")
                UpdateProgressBar(2, true);
            else
                UpdateProgressBar(2, false);
            RenderText();
        }

        private void comboSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(3, true);
            RenderText();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (txtHeight.Text.Trim() != "")
                UpdateProgressBar(4, true);
            else
                UpdateProgressBar(4, false);
            RenderText();
        }

        private void txtTrainingCentre_TextChanged(object sender, EventArgs e)
        {
            if (txtTrainingCentre.Text.Trim() != "")
                UpdateProgressBar(7, true);
            else
                UpdateProgressBar(7, false);
            RenderText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text.Trim() != "")
            {
                if (checkPassed.Checked == true)
                {
                    if (txtCourseCode.Text.Trim() != "")
                        listCourses.Items.Add(txtCourseCode.Text + " " + txtCourseName.Text + ", passed");
                    else
                        listCourses.Items.Add(txtCourseName.Text + ", passed");
                }
                else
                {
                    if (txtCourseCode.Text.Trim() != "")
                        listCourses.Items.Add(txtCourseCode.Text + " " + txtCourseName.Text + ", failed");
                    else
                        listCourses.Items.Add(txtCourseName.Text + ", failed");
                }
                UpdateProgressBar(9, true);
                btnRemoveAll.Enabled = true;
                txtCourseName.Text = "";
            }
            else
                MessageBox.Show("Course name can't be empty!");

            GenerateCourseList();
            RenderText();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listCourses.SelectedIndex != -1)
                listCourses.Items.RemoveAt(listCourses.SelectedIndex);
            
            btnRemoveSelected.Enabled = false;
            
            if (listCourses.Items.Count == 0)
            {
                UpdateProgressBar(9, false);
                btnRemoveAll.Enabled = false;
            }

            GenerateCourseList();
            RenderText();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hermaplusplus/bs12-gas-records");
        }

        private void txtColouration_TextChanged(object sender, EventArgs e)
        {
            if (txtColouration.Text.Trim() != "")
                UpdateProgressBar(6, true);
            else
                UpdateProgressBar(6, false);
            RenderText();
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            if (txtNotes.Text.Trim() != "")
                UpdateProgressBar(8, true);
            else
                UpdateProgressBar(8, false);
            RenderText();
        }

        private void listCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCourses.SelectedIndex != -1)
            {
                btnRemoveSelected.Enabled = true;
                btnRemoveAll.Enabled = true;
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            while (listCourses.Items.Count != 0)
                listCourses.Items.RemoveAt(0);
            UpdateProgressBar(9, false);
            btnRemoveSelected.Enabled = false;
            btnRemoveAll.Enabled = false;

            GenerateCourseList();
            RenderText();
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
            RenderText();
        }

        private void btnTemplateUpdate_Click(object sender, EventArgs e)
        {
            if (GetDataFromTemplates(txtPath.Text))
            {

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (txtAge.Text.Trim() != "")
                UpdateProgressBar(5, true);
            else
                UpdateProgressBar(5, false);
            RenderText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rng = new Random();
            if (rng.Next(0, 10) == rng.Next(0,10))
                this.Icon = new Icon("icons/cabbage.ico");
            else
                this.Icon = new Icon("icons/xynergy.ico");

            GetDataFromTemplates(txtPath.Text);

            barProgress.Maximum = completed.Length * 10;
            comboGrade.SelectedIndex = 0;
            comboOccupation.SelectedIndex = 0;
            comboGrade_SelectedIndexChanged(sender, e);
            comboSex.SelectedIndex = 2;

            RenderText();
        }

        private void UpdateProgressBar(int index, bool filled)
        {
            completed[index] = filled;
            int count = 0;
            for (int p = 0; p < completed.Length; p++)
            {
                if (completed[p])
                    count++;
            }
            barProgress.Value = count * 10;
        }

        private void comboOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderText();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            switch (tabOutputs.SelectedIndex)
            {
                case 0:
                    Clipboard.SetText(rtxPublic.Text);
                    break;

                case 1:
                    Clipboard.SetText(rtxMedical.Text);
                    break;

                case 2:
                    Clipboard.SetText(rtxEmployment.Text);
                    break;

                case 3:
                    Clipboard.SetText(rtxSecurity.Text);
                    break;

                default:
                    break;
            }
        }

        private void tabOutputs_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderText();
        }

        private bool GetDataFromTemplates(string rootfp)
        {
            string tempPublic, tempMedical, tempEmployment, tempSecurity;
            string[] tempTemperaments = new string[3];

            txtPath.Text.Replace(@"\", "/");
            if (!txtPath.Text.EndsWith("/"))
                txtPath.Text += "/";

            string path = txtPath.Text;

            try
            {
                tempPublic = File.ReadAllText(path + "public.txt");

                if (!tempPublic.Contains("//NAME//") ||
                    !tempPublic.Contains("//SEX//") ||
                    !tempPublic.Contains("//AGE//") ||
                    !tempPublic.Contains("//HEIGHT//") ||
                    !tempPublic.Contains("//COLOURATION//") ||
                    !tempPublic.Contains("//CENTRE//") ||
                    !tempPublic.Contains("//GRADE//") ||
                    !tempPublic.Contains("//LIST//") ||
                    !tempPublic.Contains("//NOTES//"))
                {
                    MessageBox.Show("Your public.txt file may be missing one or more of the following recommended placeholders:\n//NAME//\n//SEX//\n//AGE//\n//HEIGHT//\n//COLOURATION//\n//CENTRE//\n//GRADE//\n//LIST//\n//NOTES//", "Missing recommended placeholders");
                    //return false;
                }
            }
            catch
            {
                MessageBox.Show("Error reading public.txt!", "File read error");
                return false;
            }

            try
            {
                tempMedical = File.ReadAllText(path + "medical.txt");

                if (!tempMedical.Contains("//NAME//") ||
                    !tempMedical.Contains("//SEX//") ||
                    !tempMedical.Contains("//AGE//") ||
                    !tempMedical.Contains("//HEIGHT//") ||
                    !tempMedical.Contains("//COLOURATION//"))
                {
                    MessageBox.Show("Your medical.txt file may be missing one or more of the following recommended placeholders:\n//NAME//\n//SEX//\n//AGE//\n//HEIGHT//\n//COLOURATION//", "Missing recommended placeholders");
                    //return false;
                }
            }
            catch
            {
                MessageBox.Show("Error reading medical.txt!", "File read error");
                return false;
            }

            try
            {
                tempEmployment = File.ReadAllText(path + "employment.txt");

                if (!tempEmployment.Contains("//DATE//") ||
                    !tempEmployment.Contains("//OCCUPATION//"))
                {
                    MessageBox.Show("Your employment.txt file may be missing one or more of the following recommended placeholders::\n//DATE//\n//OCCUPATION//", "Missing recommended placeholders");
                    //return false;
                }
            }
            catch
            {
                MessageBox.Show("Error reading employment.txt!", "File read error");
                return false;
            }

            try
            {
                tempSecurity = File.ReadAllText(path + "security.txt");

                if (!tempSecurity.Contains("//NAME//") ||
                    !tempSecurity.Contains("//SEX//") ||
                    !tempSecurity.Contains("//AGE//") ||
                    !tempSecurity.Contains("//HEIGHT//") ||
                    !tempSecurity.Contains("//COLOURATION//") ||
                    !tempSecurity.Contains("//MODIFIER//") ||
                    !tempSecurity.Contains("//TEMPERAMENT//"))
                {
                    MessageBox.Show("Your security.txt file may be missing one or more of the following recommended placeholders::\n//NAME//\n//SEX//\n//AGE//\n//HEIGHT//\n//COLOURATION//\n//MODIFIER//\n//TEMPERAMENT//", "Missing recommended placeholders");
                    //return false;
                }
            }
            catch
            {
                MessageBox.Show("Error reading security.txt!", "File read error");
                return false;
            }

            try
            {
                tempTemperaments = File.ReadAllText(path + "temperaments.txt").Split(new string[] { "//SPLIT//" }, StringSplitOptions.None);
                if (tempTemperaments.Length != 3)
                {
                    MessageBox.Show("Ensure temperaments.txt contains two split points, so that:\n[positive description]\n//SPLIT//\n[neutral description\n//SPLIT//\n[negative description]");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Error reading temperaments.txt!", "File read error");
                return false;
            }

            recPublic = tempPublic;
            recMedical = tempMedical;
            recEmployment = tempEmployment;
            recSecurity = tempSecurity;
            for (int a = 0; a < 3; a++)
                recTemperaments[a] = tempTemperaments[a].Trim();

            return true;
        }

        private void GenerateCourseList()
        {
            recCourses = "";
            for (int c = 0; c < listCourses.Items.Count; c++)
            {
                recCourses += "[*] " + listCourses.Items[c].ToString().Replace("passed", "[i]passed[/i]").Replace("failed", "[i]failed[/i]");
                if (c < listCourses.Items.Count - 1)
                    recCourses += "\n";
            }
        }

        private void RenderText()
        {
            string gradelong, modifier, temperament;
            if (comboGrade.Text.EndsWith("+"))
            {
                modifier = "Positive";
                temperament = recTemperaments[0];
            }
            else if (comboGrade.Text.EndsWith("-"))
            {
                modifier = "Negative";
                temperament = recTemperaments[1];
            }
            else
            {
                modifier = "Neutral";
                temperament = recTemperaments[2];
            }
            gradelong = comboGrade.Text + ", " + comboGrade.Text.Substring(0, 1) + " " + modifier;

            string date = (DateTime.Now.Year + 288).ToString() + "-" + (DateTime.Now.Month).ToString() + "-" + (DateTime.Now.Day).ToString();

            switch (tabOutputs.SelectedIndex)
            {
                case 0:
                    rtxPublic.Text = DoAllReplacements(recPublic, gradelong, date, modifier, temperament);
                    /*rtxPublic.Text = recPublic
                        .Replace("//NAME//", txtName.Text)
                        .Replace("//SEX//", comboSex.Text)
                        .Replace("//AGE//", txtAge.Text)
                        .Replace("//HEIGHT//", txtHeight.Text)
                        .Replace("//COLOURATION//", txtColouration.Text)
                        .Replace("//CENTRE//", txtTrainingCentre.Text)
                        .Replace("//GRADE//", gradelong)
                        .Replace("//LIST//", recCourses)
                        .Replace("//NOTES//", txtNotes.Text);*/
                    break;

                case 1:
                    rtxMedical.Text = DoAllReplacements(recMedical, gradelong, date, modifier, temperament);
                    /*rtxMedical.Text = recMedical
                        .Replace("//NAME//", txtName.Text)
                        .Replace("//SEX//", comboSex.Text)
                        .Replace("//AGE//", txtAge.Text)
                        .Replace("//HEIGHT//", txtHeight.Text)
                        .Replace("//COLOURATION//", txtColouration.Text);*/
                    break;

                case 2:
                    rtxEmployment.Text = DoAllReplacements(recEmployment, gradelong, date, modifier, temperament);
                    /*rtxEmployment.Text = recEmployment
                        .Replace("//DATE//", date)
                        .Replace("//OCCUPATION//", comboOccupation.Text);*/
                    break;

                case 3:
                    rtxSecurity.Text = DoAllReplacements(recSecurity, gradelong, date, modifier, temperament);
                    /*rtxSecurity.Text = recSecurity
                        .Replace("//NAME//", txtName.Text)
                        .Replace("//SEX//", comboSex.Text)
                        .Replace("//AGE//", txtAge.Text)
                        .Replace("//HEIGHT//", txtHeight.Text)
                        .Replace("//COLOURATION//", txtColouration.Text)
                        .Replace("//MODIFIER//", modifier)
                        .Replace("//TEMPERAMENT//", temperament);*/
                    break;

                default:
                    break;
            }
        }

        private string DoAllReplacements(string record, string gradelong, string date, string modifier, string temperament)
        {
            string handle = record;
            handle = handle
                .Replace("//NAME//", txtName.Text)
                .Replace("//SEX//", comboSex.Text)
                .Replace("//AGE//", txtAge.Text)
                .Replace("//HEIGHT//", txtHeight.Text)
                .Replace("//COLOURATION//", txtColouration.Text)
                .Replace("//CENTRE//", txtTrainingCentre.Text)
                .Replace("//GRADE//", gradelong)
                .Replace("//LIST//", recCourses)
                .Replace("//NOTES//", txtNotes.Text)
                .Replace("//DATE//", date)
                .Replace("//OCCUPATION//", comboOccupation.Text)
                .Replace("//MODIFIER//", modifier)
                .Replace("//TEMPERAMENT//", temperament);
            return handle;
        }
    }
}
