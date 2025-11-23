using System;

namespace login_and_registration
{
    partial class reglog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textconfpassword = new System.Windows.Forms.TextBox();
            this.checkBoxconfpass = new System.Windows.Forms.CheckBox();
            this.button1register = new System.Windows.Forms.Button();
            this.button2clear = new System.Windows.Forms.Button();
            this.label5alrhavac = new System.Windows.Forms.Label();
            this.label5backtologin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lets Join With Us!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textusername
            // 
            this.textusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textusername.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textusername.Location = new System.Drawing.Point(56, 74);
            this.textusername.Multiline = true;
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(403, 26);
            this.textusername.TabIndex = 2;
            this.textusername.TextChanged += new System.EventHandler(this.textusername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "PASSWORD";
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpassword.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.Location = new System.Drawing.Point(56, 184);
            this.textpassword.Multiline = true;
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(403, 26);
            this.textpassword.TabIndex = 4;
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "CONFIRM PASSWORD";
            // 
            // textconfpassword
            // 
            this.textconfpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textconfpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textconfpassword.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textconfpassword.Location = new System.Drawing.Point(57, 239);
            this.textconfpassword.Multiline = true;
            this.textconfpassword.Name = "textconfpassword";
            this.textconfpassword.Size = new System.Drawing.Size(403, 26);
            this.textconfpassword.TabIndex = 6;
            this.textconfpassword.TextChanged += new System.EventHandler(this.textconfpassword_TextChanged);
            // 
            // checkBoxconfpass
            // 
            this.checkBoxconfpass.AutoSize = true;
            this.checkBoxconfpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxconfpass.Location = new System.Drawing.Point(56, 271);
            this.checkBoxconfpass.Name = "checkBoxconfpass";
            this.checkBoxconfpass.Size = new System.Drawing.Size(151, 27);
            this.checkBoxconfpass.TabIndex = 7;
            this.checkBoxconfpass.Text = "Show Password";
            this.checkBoxconfpass.UseVisualStyleBackColor = true;
            this.checkBoxconfpass.CheckedChanged += new System.EventHandler(this.checkBoxconfpass_CheckedChanged);
            // 
            // button1register
            // 
            this.button1register.BackColor = System.Drawing.Color.MediumPurple;
            this.button1register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1register.ForeColor = System.Drawing.Color.White;
            this.button1register.Location = new System.Drawing.Point(30, 357);
            this.button1register.Name = "button1register";
            this.button1register.Size = new System.Drawing.Size(474, 71);
            this.button1register.TabIndex = 8;
            this.button1register.Text = "REGISTER";
            this.button1register.UseVisualStyleBackColor = false;
            this.button1register.Click += new System.EventHandler(this.button1register_Click);
            // 
            // button2clear
            // 
            this.button2clear.BackColor = System.Drawing.Color.Lavender;
            this.button2clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2clear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2clear.Location = new System.Drawing.Point(30, 434);
            this.button2clear.Name = "button2clear";
            this.button2clear.Size = new System.Drawing.Size(474, 71);
            this.button2clear.TabIndex = 9;
            this.button2clear.Text = "CLEAR";
            this.button2clear.UseVisualStyleBackColor = false;
            this.button2clear.Click += new System.EventHandler(this.button2clear_Click);
            // 
            // label5alrhavac
            // 
            this.label5alrhavac.AutoSize = true;
            this.label5alrhavac.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5alrhavac.Location = new System.Drawing.Point(168, 508);
            this.label5alrhavac.Name = "label5alrhavac";
            this.label5alrhavac.Size = new System.Drawing.Size(208, 23);
            this.label5alrhavac.TabIndex = 10;
            this.label5alrhavac.Text = "Already have an Account";
            // 
            // label5backtologin
            // 
            this.label5backtologin.AutoSize = true;
            this.label5backtologin.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5backtologin.Location = new System.Drawing.Point(204, 541);
            this.label5backtologin.Name = "label5backtologin";
            this.label5backtologin.Size = new System.Drawing.Size(126, 23);
            this.label5backtologin.TabIndex = 11;
            this.label5backtologin.Text = "Back to LOGIN";
            this.label5backtologin.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "EMAIL";
            // 
            // textemail
            // 
            this.textemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textemail.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemail.Location = new System.Drawing.Point(56, 129);
            this.textemail.Multiline = true;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(403, 26);
            this.textemail.TabIndex = 13;
            this.textemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(57, 304);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 27);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "User";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(153, 304);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 27);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Driver";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(267, 304);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(109, 27);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Employee";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // reglog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 569);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label5backtologin);
            this.Controls.Add(this.label5alrhavac);
            this.Controls.Add(this.button2clear);
            this.Controls.Add(this.button1register);
            this.Controls.Add(this.checkBoxconfpass);
            this.Controls.Add(this.textconfpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reglog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTAL ADMIN";
            this.Load += new System.EventHandler(this.reglog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textconfpassword;
        private System.Windows.Forms.CheckBox checkBoxconfpass;
        private System.Windows.Forms.Button button1register;
        private System.Windows.Forms.Button button2clear;
        private System.Windows.Forms.Label label5alrhavac;
        private System.Windows.Forms.Label label5backtologin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

