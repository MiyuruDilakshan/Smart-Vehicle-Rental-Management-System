using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login_and_registration
{
    public partial class Settings : Form
    {
        private string connectionString ="Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\senith\\Desktop\\Dam Seniya Rentals\\DamSeniyaRentals.mdf';Integrated Security=True;Connect Timeout=30";

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Initialize the form or load any necessary data
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Get values from input controls
            string vehicleName = richTextBox2.Text;
            string vehicleCode = richTextBox4.Text;
            string perDayPayment = numericUpDown1.Text;
            string promo = numericUpDown2.Text;
            int passengerCount;
            string offerCode = richTextBox9.Text;
            string gearMethod = richTextBox5.Text;
            string imagePath = richTextBox13.Text;
            string category = comboBox1.Text;
            string AirConditioned = richTextBox15.Text;
            // Validate and convert inputs
            if (string.IsNullOrWhiteSpace(vehicleName) ||
                string.IsNullOrWhiteSpace(vehicleCode) ||
               !int.TryParse(numericUpDown3.Value.ToString(), out passengerCount))
            {
                MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert vehicle details into database
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO vehicles (vehicle_name, vehicle_code, perdaypayment, offercode, promo, gear_method, image_path, passengercount, category, AirConditioned)
                        VALUES (@VehicleName, @VehicleCode, @PerDayPayment, @OfferCode, @Promo, @GearMethod, @ImagePath, @PassengerCount ,@Category, @AirConditioned)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleName", vehicleName);
                        command.Parameters.AddWithValue("@VehicleCode", vehicleCode);
                        command.Parameters.AddWithValue("@PerDayPayment", perDayPayment);
                        command.Parameters.AddWithValue("@OfferCode", string.IsNullOrEmpty(offerCode) ? (object)DBNull.Value : offerCode);
                        command.Parameters.AddWithValue("@Promo", string.IsNullOrEmpty(promo) ? (object)DBNull.Value : promo);
                        command.Parameters.AddWithValue("@GearMethod", gearMethod);
                        command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath);
                        command.Parameters.AddWithValue("@PassengerCount", passengerCount);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@AirConditioned", AirConditioned);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle details added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputs(); // Optionally clear inputs after saving
                        }
                        else
                        {
                            MessageBox.Show("Failed to add vehicle details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            // Optionally clear input fields after successful save
            richTextBox2.Clear();
            richTextBox4.Clear();
            numericUpDown1.Value = 0;
            richTextBox9.Clear();
            numericUpDown2.Value = 0;
            richTextBox5.Clear ();
            richTextBox13.Clear();
            numericUpDown3.Value = 0;
            richTextBox15.Clear();
        }

        // Ensure all other button and event handlers are wired up correctly

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard loginForm = new dashboard();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentingHistory loginForm = new RentingHistory();
            loginForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vehicles loginForm = new vehicles();
            loginForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Offers loginForm = new Offers();
            loginForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaymentHistory loginForm = new PaymentHistory();
            loginForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings loginForm = new Settings();
            loginForm.Show();
            this.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
         
        }

     

        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void richTextBox22_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load_1(object sender, EventArgs e)
        {

        }
    }
}
