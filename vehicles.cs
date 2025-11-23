using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login_and_registration
{
    public partial class vehicles : Form
    {
        private string connectionString ="Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\senith\\Desktop\\Dam Seniya Rentals\\DamSeniyaRentals.mdf\';Integrated Security=True;Connect Timeout=30";

        public vehicles()
        {
            InitializeComponent();
        }

        private void vehicles_Load(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        private void LoadVehicles(string category = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM vehicles";
                    if (!string.IsNullOrEmpty(category) && category != "All")
                    {
                        query += " WHERE category = @Category";
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    if (!string.IsNullOrEmpty(category) && category != "All")
                    {
                        command.Parameters.AddWithValue("@Category", category);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    flowLayoutPanel2.Controls.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string imagePath = row["image_path"].ToString(); // Adjust column name if necessary
                        decimal pricePerDay = Convert.ToDecimal(row["perdaypayment"]);
                        string AirConditioned = Convert.ToString(row["AirConditioned"]);
                        string gearMethod = row["gear_method"].ToString();
                        int passengerCount = Convert.ToInt32(row["passengercount"]);

                        vehicleCard card = new vehicleCard();
                        card.SetVehicleData(imagePath, pricePerDay, AirConditioned, gearMethod, passengerCount);
                        flowLayoutPanel2.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem?.ToString();
            LoadVehicles(selectedCategory);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Offers offersForm = new Offers();
            offersForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentingHistory rentingHistoryForm = new RentingHistory();
            rentingHistoryForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vehicles vehiclesForm = new vehicles();
            vehiclesForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard dashboardForm = new dashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaymentHistory paymentHistoryForm = new PaymentHistory();
            paymentHistoryForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

    

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
