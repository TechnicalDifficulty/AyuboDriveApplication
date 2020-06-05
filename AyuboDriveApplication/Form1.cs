using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDriveApplication
{
    public partial class Form1 : Form
    {
        //variables

        int totalDays;
        String carTypes;
        bool driverNeeded = false;
        float driverCost = 500;
        float totalDriverCost;
        int days;
        int weeks;
        int months;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rent_btn_Click(object sender, EventArgs e)
        {
            rent_form rent = new rent_form();
            rent.Show();
        }
    }
}
