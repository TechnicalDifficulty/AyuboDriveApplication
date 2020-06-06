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

        private void hire_btn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void add_vehicle_btn_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

        }
    }
}
