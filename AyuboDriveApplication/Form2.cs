using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;


namespace AyuboDriveApplication
{
    public partial class rent_form : Form
    {
        //variables

        int totalDays;
       
        bool driverNeeded = false;
        float driverCost = 500;
        float totalDriverCost;
        private int DailyPrice;
        private int WeeklyPrice;
        private int MonthlyPrice;
        int days;
        int weeks;
        int months;
        

        public rent_form()
        {
            InitializeComponent();
            vehicleComboBoxFill();
        }

        public void sqlConnection()
        {
           
        }

        public void vehicleComboBoxFill()
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            

            string query = "Select * from AYU_Vehicles";
            SqlCommand sqlCmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                type_of_vehicles_combo_box.Items.Add(sqlReader["VehicleType"].ToString());
            }

            sqlReader.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void driver_needed_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (driver_needed_checkbox.Checked)
            {
                driverNeeded = true;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (start_date_picker.Value==null || end_date_picker.Value==null)
            {
                MessageBox.Show("Please enter Valid No. of Days");
            }
            else
            {
                if (type_of_vehicles_combo_box.SelectedItem==null)
                {
                    MessageBox.Show("Please select a vehicle type");
                }
                else
                {
                    var vehicleType = type_of_vehicles_combo_box.SelectedItem.ToString();
                    //calculate the rent
                    calculateRentFunction(end_date_picker.Value,start_date_picker.Value,driverNeeded,vehicleType);
                }

            }
        }

        public void getVehiclePrice(string vehicleType)
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = "Select * from AYU_Vehicles where VehicleType=@vehicleType";
            SqlCommand sqlCmd = new SqlCommand(query, con);

            sqlCmd.Parameters.AddWithValue("@vehicleType", vehicleType);
            
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {

                DailyPrice = int.Parse(sqlReader["DailyPrice"].ToString());
                WeeklyPrice = int.Parse(sqlReader["WeeklyPrice"].ToString());
                MonthlyPrice = int.Parse(sqlReader["MonthlyPrice"].ToString());

            }

            sqlReader.Close();

        }
        public void calculateRentFunction(DateTime end_date_picker, DateTime start_date_picker,bool driverNeeded, string vehicleType)
        {
         
            TimeSpan diference = end_date_picker - start_date_picker;

            totalDays = diference.Days;

            if (totalDays == 0)
            {
                MessageBox.Show("Invalid days");
            }

            else if (totalDays < 7)
            {
                days = totalDays;
                weeks = 0;
                months = 0;
            }

            else if (totalDays < 30)
            {
                weeks = totalDays / 7;
                days = totalDays % 7;
                months = 0;
            }

            else
            {
                months = totalDays / 30;
                if ((totalDays % 30) < 7)
                {
                    days = totalDays % 30;
                    weeks = 0;
                }
                else
                {
                    weeks = (totalDays % 30) / 7;
                    days = (totalDays % 30) % 7;
                }
            }


            if (driverNeeded)
            {
                totalDriverCost = driverCost * totalDays;
            }
            else
            {
                totalDriverCost = 0;
            }

            getVehiclePrice(vehicleType);

            float rent = (days * DailyPrice) + (weeks * WeeklyPrice) + (months * MonthlyPrice) + totalDriverCost;

            MessageBox.Show(" Detailed Bill" + "\n" + "___________________________________________" + "\n" + "\n" + "No of Days =" + days 
                + "\n" + "Daily charge = Rs. " + DailyPrice + "\n" + "No of weeks =" 
                + weeks + "\n" + "Weekly charge = Rs. " + WeeklyPrice + "\n" + "No of Months =" 
                + months + "\n" + "Monthly charge = Rs. " + MonthlyPrice + "\n" + "\n" + "Driver daily charge = Rs. " 
                + driverCost + "\n" + "Total driver charge = Rs. " + totalDriverCost + "\n" + "------------------------------------" + "\n" + "\n" + "Rent is Rs." 
                + rent);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void start_date_picker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
