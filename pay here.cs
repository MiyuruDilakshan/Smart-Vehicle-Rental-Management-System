using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login_and_registration
{
    public partial class Form3 : Form
    {
        // Connection string for your database
        private string connectionString ="Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\senith\\Desktop\\Dam Seniya Rentals\\DamSeniyaRentals.mdf';Integrated Security=True;Connect Timeout=30";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox19_TextChanged(object sender, EventArgs e)
        {

        }


        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string paymentCode = richTextBox2.Text.Trim();
            decimal amount;
            if (!decimal.TryParse(richTextBox19.Text.Trim(), out amount))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }
            string holderName = richTextBox6.Text.Trim();

            if (string.IsNullOrEmpty(paymentCode) || string.IsNullOrEmpty(holderName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Payments (PaymentCode, Amount, HolderName) VALUES (@PaymentCode, @Amount, @HolderName)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentCode", paymentCode);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@HolderName", holderName);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Payment done successfully!");

                        // Clear the fields after successful payment
                        richTextBox2.Clear();
                        richTextBox19.Clear();
                        richTextBox6.Clear();
                        richTextBox3.Clear();
                        richTextBox8.Clear();
                        richTextBox10.Clear();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }


        private void button10_Click(object sender, EventArgs e)
        {
            vehicles vehiclesForm = new vehicles();
            vehiclesForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            dashboard dashboardForm = new dashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void label1damseniya_Click(object sender, EventArgs e)
        {

        }
    }
}
