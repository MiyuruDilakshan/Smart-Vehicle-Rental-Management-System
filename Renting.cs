using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_and_registration
{
    public partial class Renting : Form
    {
        private string connectionString ="Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\senith\\Desktop\\Dam Seniya Rentals\\DamSeniyaRentals.mdf';Integrated Security=True;Connect Timeout=30";
        private decimal vehiclePerDayPayment = 100;
      

        public Renting()
        {
            InitializeComponent();
        }

     

        private void label2_Click(object sender, EventArgs e)
        {

        }

    
       

      
        private void button7_Click(object sender, EventArgs e)
        {
            // Vehicle Details
            string vehicleName = richTextBox2.Text.Trim();
            string vehicleCode = richTextBox4.Text.Trim();
            string offerCode = richTextBox21.Text.Trim();
            DateTime pickupDate = monthCalendar1.SelectionStart;
            DateTime dropoffDate = monthCalendar2.SelectionStart;

            // Driver Details
            string driverName = richTextBox16.Text.Trim();
            int driverAge;
            string licenseNumber = richTextBox18.Text.Trim();
            string phoneNumber = richTextBox19.Text.Trim();
            string address = richTextBox20.Text.Trim();
            decimal payment;

            // Validate driver age
            if (!int.TryParse(richTextBox17.Text.Trim(), out driverAge))
            {
                MessageBox.Show("Please enter a valid driver age.");
                return;
            }

            // Validate payment
            if (!decimal.TryParse(richTextBox23.Text.Trim(), out payment))
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return;
            }

            if (string.IsNullOrEmpty(vehicleName) || string.IsNullOrEmpty(vehicleCode) || string.IsNullOrEmpty(driverName) ||
                string.IsNullOrEmpty(licenseNumber) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Calculate duration and total payment
            TimeSpan duration = dropoffDate - pickupDate;
            int days = duration.Days + 1; // Include both pickup and dropoff dates
            decimal totalPayment = vehiclePerDayPayment * days ;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Rentals (VehicleName, VehicleCode, OfferCode, PickupDate, DropoffDate, DriverName, DriverAge, LicenseNumber, PhoneNumber, Address, Payment) " +
                                   "VALUES (@VehicleName, @VehicleCode, @OfferCode, @PickupDate, @DropoffDate, @DriverName, @DriverAge, @LicenseNumber, @PhoneNumber, @Address, @Payment)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleName", vehicleName);
                        command.Parameters.AddWithValue("@VehicleCode", vehicleCode);
                        command.Parameters.AddWithValue("@OfferCode", offerCode);
                        command.Parameters.AddWithValue("@PickupDate", pickupDate);
                        command.Parameters.AddWithValue("@DropoffDate", dropoffDate);
                        command.Parameters.AddWithValue("@DriverName", driverName);
                        command.Parameters.AddWithValue("@DriverAge", driverAge);
                        command.Parameters.AddWithValue("@LicenseNumber", licenseNumber);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Payment", totalPayment);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Rental process completed successfully!");
                        Form3 paymentHistoryForm = new Form3();
                        paymentHistoryForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            richTextBox2.Clear();
            richTextBox4.Clear();
            richTextBox21.Clear();
            richTextBox16.Clear();
            richTextBox18.Clear();
            richTextBox19.Clear();
            richTextBox20.Clear();
            richTextBox17.Clear();
            richTextBox23.Clear();
            monthCalendar1.SelectionStart = DateTime.Now;
            monthCalendar2.SelectionStart = DateTime.Now;
            vehiclePerDayPayment = 0;
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void Renting_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }

        private void richTextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentingHistory rentingHistoryForm = new RentingHistory();
            rentingHistoryForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard dashboardForm = new dashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vehicles vehiclesForm = new vehicles();
            vehiclesForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Offers offersForm = new Offers();
            offersForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaymentHistory paymentHistoryForm = new PaymentHistory();
            paymentHistoryForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RentingHistory rentingHistoryForm = new RentingHistory();
            rentingHistoryForm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
