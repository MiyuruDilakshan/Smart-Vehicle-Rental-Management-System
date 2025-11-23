using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_and_registration
{
    public partial class Offers : Form
    {
        public Offers()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
