using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace AyuboDriveApplication
{
    public partial class Form3 : Form
    {
        int totalDays;


        int driverCost = 500;
        int totalDriverCost;
        private int DailyPrice;
        int kmInput;
        int hoursInput;
        private int hourValue;
        private int kmValue;
        int maxKms;
        int maxHours;
        int driverOverNightCharge = 500;
        int totalDriverOverNightCharge;
        int vehicleNightParkRate = 700;
        int totalVehicleNightParkRate;
        int extraKmCharge;
        int oneKmCharge = 100;
        int waitingCharge;
        int oneHourWaitingCharge = 150;
        string packageType;
        public Form3()
        {
            InitializeComponent();
            pacakageComboBoxFill();
            vehicleComboBoxFill();
        }

        public void vehicleComboBoxFill()
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);


            string query = "Select * from AYU_Vehicles";
            SqlCommand sqlCmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                type_of_vehicles_combo_box.Items.Add(sqlReader["VehicleType"].ToString());
            }

            sqlReader.Close();

        }

        public void pacakageComboBoxFill()
        {
            //select * from AYU_Packages

            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);


            string query = "select * from AYU_Packages";
            SqlCommand sqlCmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                package_list_combo_box.Items.Add(sqlReader["PackageType"].ToString());
            }

            sqlReader.Close();
        }
        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (start_date_picker.Value == null || end_date_picker.Value == null )
            {
                MessageBox.Show("Please enter Valid No. of Days");
            }
            else
            {
                if (type_of_vehicles_combo_box.SelectedItem == null||package_list_combo_box==null 
                    || String.IsNullOrEmpty(kilometers_text.Text) || String.IsNullOrEmpty(hours_txt.Text))
                {
                    MessageBox.Show("Please select a vehicle type / package type / hours / kilometers");
                }
                else
                {
                    var vehicleType = type_of_vehicles_combo_box.SelectedItem.ToString();
                    var packageType = package_list_combo_box.SelectedItem.ToString();
                    
                    calculateHireFunction(end_date_picker.Value, start_date_picker.Value, vehicleType);
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
 
            }

            sqlReader.Close();

        }

        public void getHireType(string packageType)
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = "Select * from AYU_Packages where PackageType=@packageType";
            SqlCommand sqlCmd = new SqlCommand(query, con);

            sqlCmd.Parameters.AddWithValue("@packageType", packageType);

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                hourValue = int.Parse(sqlReader["MaxHour"].ToString());
                kmValue= int.Parse(sqlReader["MaxKm"].ToString());
            }

            sqlReader.Close();
        }

        public void calculateHireFunction(DateTime end_date_picker, DateTime start_date_picker, string vehicleType)
        {
            TimeSpan diference = end_date_picker - start_date_picker;
            hoursInput = int.Parse(hours_txt.Text);
            kmInput = int.Parse(hours_txt.Text);
            packageType = package_list_combo_box.SelectedItem.ToString();

            totalDays = diference.Days;

            totalDriverCost = driverCost * totalDays;

            getVehiclePrice(vehicleType);
            getHireType(packageType);

            if (totalDays == 1)
            {
                maxHours = hoursInput;
                maxKms = kmInput;
                totalDriverOverNightCharge = 0;
                totalVehicleNightParkRate = 0;
            }

            else if(totalDays>1)
            {
                maxHours = 0;
                maxKms = totalDays * kmInput;
                totalDriverOverNightCharge = driverOverNightCharge * (totalDays - 1);
                totalVehicleNightParkRate = vehicleNightParkRate * (totalDays - 1);
            }

            if (maxKms > kmInput)
            {

                extraKmCharge = 0;

            }

            else
            {
                extraKmCharge = oneKmCharge * (kmInput - maxKms);

            }


            if (maxHours == 0 || maxHours > hoursInput)
            {
                waitingCharge = 0;
            }

            else
            {
                waitingCharge = oneHourWaitingCharge * (hoursInput - maxHours);

            }

            int hireCharge = DailyPrice + waitingCharge + extraKmCharge + totalDriverOverNightCharge + totalVehicleNightParkRate;

            MessageBox.Show("Detailed bill" + "\n" + "___________________________________________" 
                + "\n" + "\n"+"Selected Package :" +packageType + "\n" + "\n" + "No of Days =" + totalDays + "\n" + "Package charge = Rs. " 
                + DailyPrice + "\n" + "\n" + "Allowed waiting hours = " + maxHours + "\n" + "Allocated waiting hours = " 
                + hoursInput + "\n" + "Hourly charge = Rs. " + oneHourWaitingCharge + "\n" + "Waiting Charge = Rs. " 
                + waitingCharge + "\n" + "\n" + "Allowed Km = " + maxKms + "\n" + "Allocated km " 
                + kmInput + "\n" + " Extra Km charge per 1 Km = Rs. " + oneKmCharge + "\n" + "Extra Km charge = Rs. " 
                + extraKmCharge + "\n" + "\n" + "Driver overnight charge per day = Rs. " + driverOverNightCharge + "\n" + "Driver overnight charge = Rs. " 
                + totalDriverOverNightCharge + "\n" + "\n" + "Vehicle night park rate = Rs. " + vehicleNightParkRate + "\n" + "Vehicle night park rate = Rs." 
                + totalVehicleNightParkRate + "\n" + "------------------------------------" + "\n" + "\n" + "The Total Hire Amount = Rs." + hireCharge);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
