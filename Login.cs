using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login_and_registration
{
    public partial class Login : Form
    {
        // Connection string for your database
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\senith\\Desktop\\Dam Seniya Rentals\\DamSeniyaRentals.mdf';Integrated Security=True;Connect Timeout=30";

        public Login()
        {
            InitializeComponent();
        }

        private void Form2Login_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            // Assume username and password are TextBox controls in your form
            string username = textBoxUsername.Text.Trim(); // Replace textBoxUsername with the actual name of your username TextBox control
            string password = textpassword.Text.Trim(); // Replace textBoxPassword with the actual name of your password TextBox control

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Consider hashing the password before comparing

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login successful!");

                            // Redirect to Home form after successful login
                            dashboard homeForm = new dashboard();
                            homeForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void label1damseniya_Click(object sender, EventArgs e)
        {

        }

        private void textpassword11_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxconfpass2_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            textpassword.UseSystemPasswordChar = !showpassword.Checked; // Replace textBoxPassword with the actual name of your password TextBox control
        }

        private void button3clear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear(); // Replace textBoxUsername with the actual name of your username TextBox control
            textpassword.Clear(); // Replace textBoxPassword with the actual name of your password TextBox control
        }

        private void label5backtologinee_Click(object sender, EventArgs e)
        {
            // Redirect to reglog form
            reglog reglogForm = new reglog();
            reglogForm.Show();
            this.Hide();
        }

        private void createanaccount_Click(object sender, EventArgs e)
        {
            reglog reglogForm = new reglog();
            reglogForm.Show();
            this.Hide();
        }
    }
}
