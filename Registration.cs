using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login_and_registration
{
    public partial class reglog : Form
    {
        // Connection string for your database
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\senith\\Desktop\\Dam Seniya Rentals\\DamSeniyaRentals.mdf';Integrated Security=True;Connect Timeout=30";

        public reglog()
        {
            InitializeComponent();
        }

        private void button1register_Click(object sender, EventArgs e)
        {
            string username = textusername.Text.Trim();
            string password = textpassword.Text.Trim();
            string confirmPassword = textconfpassword.Text.Trim();
            string email = textemail.Text.Trim();
            string category = radioButton1.Checked ? "User" : radioButton2.Checked ? "Driver" : "Employee";

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password, Email, Category) VALUES (@Username, @Password, @Email, @Category)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Consider hashing the password before storing it
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Category", category);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");

                        // Redirect to Home form after successful registration
                        dashboard homeForm = new dashboard();
                        homeForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2clear_Click(object sender, EventArgs e)
        {
            textusername.Clear();
            textpassword.Clear();
            textconfpassword.Clear();
            textemail.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void checkBoxconfpass_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            textpassword.UseSystemPasswordChar = !checkBoxconfpass.Checked;
            textconfpassword.UseSystemPasswordChar = !checkBoxconfpass.Checked;
        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {
            // Handle any logic needed when text in username field changes
        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {
            // Handle any logic needed when text in password field changes
        }

        private void textconfpassword_TextChanged(object sender, EventArgs e)
        {
            // Handle any logic needed when text in confirm password field changes
        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {
            // Handle any logic needed when text in email field changes
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Handle any logic needed when category radio button changes
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Handle any logic needed when category radio button changes
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Handle any logic needed when category radio button changes
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Navigate to login form or handle navigation logic
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Redirect to Login form
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle form load logic if needed
        }
        private void reglog_Load(object sender, EventArgs e)
        {
            // Handle form load logic if needed
        }
    }
}
