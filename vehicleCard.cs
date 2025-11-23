using System;
using System.Drawing;
using System.Windows.Forms;

namespace login_and_registration
{
    public partial class vehicleCard : UserControl
    {
       


        public vehicleCard()
        {
            InitializeComponent();
       
        }

        private void InitializeCustomComponents()
        {
            // Initialize controls
           

            this.Controls.Add(pictureBoxVehicle);
            this.Controls.Add(labelPricePerDay);
            this.Controls.Add(labelAirConditioned);
            this.Controls.Add(labelGearMethod);
            this.Controls.Add(labelPassengerCount);
            this.Controls.Add(button5);
        }

        public void SetVehicleData(string imagePath, decimal pricePerDay, string AirConditioned, string gearMethod, int passengerCount)
        {
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                pictureBoxVehicle.Image = Image.FromFile(imagePath);
            }
            else
            {
                string defaultImagePath = @"C:\Users\senith\Desktop\Dam Seniya Rentals\images\DS logo.png";
                if (System.IO.File.Exists(defaultImagePath))
                {
                    pictureBoxVehicle.Image = Image.FromFile(defaultImagePath);
                }
                else
                {
                    // Handle missing default image
                    MessageBox.Show("Default image not found!");
                }
            }

                labelPricePerDay.Text = $"${pricePerDay} per day";
            labelAirConditioned.Text = $"Air Conditioned: {AirConditioned}";
            labelGearMethod.Text = $"Gear Method: {gearMethod}";
            labelPassengerCount.Text = $"Passengers: {passengerCount}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Navigate to the Renting form
            Renting rentingForm = new Renting();
            rentingForm.Show();
       
        }

        private void VehicleCard_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxVehicle_Click(object sender, EventArgs e)
        {
            // Custom click logic for picture box
        }
    }
}
