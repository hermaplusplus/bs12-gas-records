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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rng = new Random();
            if (rng.Next(0, 10) == rng.Next(0,10))
                this.Icon = new Icon("cabbage.ico");
            else
                this.Icon = new Icon("xynergy.ico");
        }
    }
}
