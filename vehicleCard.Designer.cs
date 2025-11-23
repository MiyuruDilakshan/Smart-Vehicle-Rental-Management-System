namespace login_and_registration
{
    partial class vehicleCard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxVehicle;
        private System.Windows.Forms.Label labelPricePerDay;
        private System.Windows.Forms.Label labelAirConditioned;
        private System.Windows.Forms.Label labelGearMethod;
        private System.Windows.Forms.Label labelPassengerCount;
        private System.Windows.Forms.Button button5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBoxVehicle = new System.Windows.Forms.PictureBox();
            this.labelPricePerDay = new System.Windows.Forms.Label();
            this.labelAirConditioned = new System.Windows.Forms.Label();
            this.labelGearMethod = new System.Windows.Forms.Label();
            this.labelPassengerCount = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVehicle
            // 
            this.pictureBoxVehicle.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxVehicle.Name = "pictureBoxVehicle";
            this.pictureBoxVehicle.Size = new System.Drawing.Size(200, 120);
            this.pictureBoxVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVehicle.TabIndex = 0;
            this.pictureBoxVehicle.TabStop = false;
            this.pictureBoxVehicle.Click += new System.EventHandler(this.pictureBoxVehicle_Click);
            // 
            // labelPricePerDay
            // 
            this.labelPricePerDay.AutoSize = true;
            this.labelPricePerDay.Location = new System.Drawing.Point(10, 140);
            this.labelPricePerDay.Name = "labelPricePerDay";
            this.labelPricePerDay.Size = new System.Drawing.Size(107, 16);
            this.labelPricePerDay.TabIndex = 1;
            this.labelPricePerDay.Text = "Price per day: $0";
            // 
            // labelAirConditioned
            // 
            this.labelAirConditioned.AutoSize = true;
            this.labelAirConditioned.Location = new System.Drawing.Point(10, 160);
            this.labelAirConditioned.Name = "labelAirConditioned";
            this.labelAirConditioned.Size = new System.Drawing.Size(122, 16);
            this.labelAirConditioned.TabIndex = 2;
            this.labelAirConditioned.Text = "Air Conditioned: No";
            // 
            // labelGearMethod
            // 
            this.labelGearMethod.AutoSize = true;
            this.labelGearMethod.Location = new System.Drawing.Point(10, 180);
            this.labelGearMethod.Name = "labelGearMethod";
            this.labelGearMethod.Size = new System.Drawing.Size(91, 16);
            this.labelGearMethod.TabIndex = 3;
            this.labelGearMethod.Text = "Gear Method: ";
            // 
            // labelPassengerCount
            // 
            this.labelPassengerCount.AutoSize = true;
            this.labelPassengerCount.Location = new System.Drawing.Point(10, 200);
            this.labelPassengerCount.Name = "labelPassengerCount";
            this.labelPassengerCount.Size = new System.Drawing.Size(93, 16);
            this.labelPassengerCount.TabIndex = 4;
            this.labelPassengerCount.Text = "Passengers: 0";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkMagenta;
            this.button5.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(34, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "Rent";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // vehicleCard
            // 
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelPassengerCount);
            this.Controls.Add(this.labelGearMethod);
            this.Controls.Add(this.labelAirConditioned);
            this.Controls.Add(this.labelPricePerDay);
            this.Controls.Add(this.pictureBoxVehicle);
            this.Name = "vehicleCard";
            this.Size = new System.Drawing.Size(219, 286);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
