using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login_and_registration
{
    public partial class RentingHistory : Form
    {
        // Connection string for your database
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\senith\\Desktop\\Dam Seniya Rentals\\DamSeniyaRentals.mdf';Integrated Security=True;Connect Timeout=30";

        public RentingHistory()
        {
            InitializeComponent();
            LoadRentals();
        }

        private void LoadRentals()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Rentals";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

     

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int rentalId = Convert.ToInt32(selectedRow.Cells["RentalId"].Value);

                var result = MessageBox.Show("Are you sure you want to delete this rental?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM Rentals WHERE RentalId = @RentalId";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@RentalId", rentalId);
                                command.ExecuteNonQuery();
                            }
                        }
                        // Reload rentals after deleting
                        LoadRentals();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

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

        private void button5_Click(object sender, EventArgs e)
        {
            Settings loginForm = new Settings();
            loginForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RentingHistory_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
