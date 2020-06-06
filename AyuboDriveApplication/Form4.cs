using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace AyuboDriveApplication
{
    public partial class Form4 : Form
    {

        string VehicleType;
        int DailyPrice;
        int WeeklyPrice;
        int MonthlyPrice;

        string PackageType;
        int PackageCharge;

        public Form4()
        {
            InitializeComponent();
            pacakageComboBoxFill();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            
                if (String.IsNullOrEmpty(daily_charge_txt.Text)|| String.IsNullOrEmpty(weekly_charge_txt.Text)|| String.IsNullOrEmpty(monthly_charge_text.Text)
                    || String.IsNullOrEmpty(vehicle_type_txt.Text) || String.IsNullOrEmpty(package_charge_txt.Text))
                {
                    MessageBox.Show("Records cannot be empty!");
                }
            else
            {
                VehicleType = vehicle_type_txt.Text.ToString();
                DailyPrice = int.Parse(daily_charge_txt.Text);
                WeeklyPrice = int.Parse(weekly_charge_txt.Text);
                MonthlyPrice = int.Parse(monthly_charge_text.Text);
                PackageType = package_list_combo_box.SelectedItem.ToString();
                PackageCharge = int.Parse(package_charge_txt.Text);

                insertIntoVehicles(VehicleType,DailyPrice,WeeklyPrice,MonthlyPrice);
                insertIntoPackages(PackageType,PackageCharge);
            }
  
        }

        public void insertIntoVehicles(string VehicleType,int DailyPrice,int WeeklyPrice,int MonthlyPrice)
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = "insert into AYU_Vehicles(VehicleType,DailyPrice,WeeklyPrice,MonthlyPrice,CreatedDate)"+ "Values(@VehicleType,@DailyPrice,@WeeklyPrice,@MonthlyPrice,GETDATE())";
            SqlCommand sqlCmd = new SqlCommand(query, con);

            sqlCmd.Parameters.AddWithValue("@VehicleType", VehicleType);
            sqlCmd.Parameters.AddWithValue("@DailyPrice", DailyPrice);
            sqlCmd.Parameters.AddWithValue("@WeeklyPrice", WeeklyPrice);
            sqlCmd.Parameters.AddWithValue("@MonthlyPrice", MonthlyPrice);
            sqlCmd.Parameters.AddWithValue("@CreatedDate", "GETDATE()");
            sqlCmd.ExecuteNonQuery();
            con.Close();
        }

        public void insertIntoPackages(string PackageType, int PackageCharge)
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = "insert into AYU_Packages(PackageType,PackageCharge,CreatedDate)" + "Values(@PackageType,@PackageCharge,GETDATE())";
            SqlCommand sqlCmd = new SqlCommand(query, con);

            sqlCmd.Parameters.AddWithValue("@PackageType", PackageType);
            sqlCmd.Parameters.AddWithValue("@PackageCharge", PackageCharge);
            sqlCmd.Parameters.AddWithValue("@CreatedDate", "GETDATE()");
            sqlCmd.ExecuteNonQuery();
            con.Close();
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
