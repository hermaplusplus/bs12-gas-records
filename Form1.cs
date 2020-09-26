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
            }
            else if (comboGrade.SelectedIndex >= 3 && comboGrade.SelectedIndex <= 5)
            {
                comboOccupation.Items.Clear();
                comboOccupation.Items.Add("Chef");
                comboOccupation.Items.Add("Bartender");
                comboOccupation.Items.Add("Deck Technician");
                comboOccupation.SelectedIndex = 0;
            }
            else if (comboGrade.SelectedIndex >= 6 && comboGrade.SelectedIndex <= 8)
            {
                comboOccupation.Items.Clear();
                comboOccupation.Items.Add("Janitor");
                comboOccupation.SelectedIndex = 0;
            }
            else
                comboOccupation.Items.Clear();
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
    }
}
