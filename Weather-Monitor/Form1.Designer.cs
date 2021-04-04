
namespace Weather_Monitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_max_5 = new System.Windows.Forms.Label();
            this.lbl_max_4 = new System.Windows.Forms.Label();
            this.lbl_max_3 = new System.Windows.Forms.Label();
            this.lbl_max_2 = new System.Windows.Forms.Label();
            this.lbl_min_5 = new System.Windows.Forms.Label();
            this.lbl_min_4 = new System.Windows.Forms.Label();
            this.lbl_min_3 = new System.Windows.Forms.Label();
            this.lbl_min_2 = new System.Windows.Forms.Label();
            this.lbl_day_5 = new System.Windows.Forms.Label();
            this.lbl_day_4 = new System.Windows.Forms.Label();
            this.lbl_day_3 = new System.Windows.Forms.Label();
            this.lbl_day_2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl_humil = new System.Windows.Forms.Label();
            this.lbl_wind = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1127, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(425, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bem-vindo ao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(676, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(600, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Clima";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_max_5);
            this.panel2.Controls.Add(this.lbl_max_4);
            this.panel2.Controls.Add(this.lbl_max_3);
            this.panel2.Controls.Add(this.lbl_max_2);
            this.panel2.Controls.Add(this.lbl_min_5);
            this.panel2.Controls.Add(this.lbl_min_4);
            this.panel2.Controls.Add(this.lbl_min_3);
            this.panel2.Controls.Add(this.lbl_min_2);
            this.panel2.Controls.Add(this.lbl_day_5);
            this.panel2.Controls.Add(this.lbl_day_4);
            this.panel2.Controls.Add(this.lbl_day_3);
            this.panel2.Controls.Add(this.lbl_day_2);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.lbl_humil);
            this.panel2.Controls.Add(this.lbl_wind);
            this.panel2.Controls.Add(this.lbl_day);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbl_cityName);
            this.panel2.Controls.Add(this.lbl_country);
            this.panel2.Controls.Add(this.lbl_temp);
            this.panel2.Location = new System.Drawing.Point(200, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 480);
            this.panel2.TabIndex = 23;
            // 
            // lbl_max_5
            // 
            this.lbl_max_5.AutoSize = true;
            this.lbl_max_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_max_5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_max_5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_max_5.Location = new System.Drawing.Point(590, 412);
            this.lbl_max_5.Name = "lbl_max_5";
            this.lbl_max_5.Size = new System.Drawing.Size(77, 32);
            this.lbl_max_5.TabIndex = 23;
            this.lbl_max_5.Text = "Date2";
            // 
            // lbl_max_4
            // 
            this.lbl_max_4.AutoSize = true;
            this.lbl_max_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_max_4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_max_4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_max_4.Location = new System.Drawing.Point(437, 412);
            this.lbl_max_4.Name = "lbl_max_4";
            this.lbl_max_4.Size = new System.Drawing.Size(77, 32);
            this.lbl_max_4.TabIndex = 22;
            this.lbl_max_4.Text = "Date2";
            // 
            // lbl_max_3
            // 
            this.lbl_max_3.AutoSize = true;
            this.lbl_max_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_max_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_max_3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_max_3.Location = new System.Drawing.Point(289, 412);
            this.lbl_max_3.Name = "lbl_max_3";
            this.lbl_max_3.Size = new System.Drawing.Size(77, 32);
            this.lbl_max_3.TabIndex = 21;
            this.lbl_max_3.Text = "Date2";
            // 
            // lbl_max_2
            // 
            this.lbl_max_2.AutoSize = true;
            this.lbl_max_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_max_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_max_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_max_2.Location = new System.Drawing.Point(153, 412);
            this.lbl_max_2.Name = "lbl_max_2";
            this.lbl_max_2.Size = new System.Drawing.Size(77, 32);
            this.lbl_max_2.TabIndex = 20;
            this.lbl_max_2.Text = "Date2";
            // 
            // lbl_min_5
            // 
            this.lbl_min_5.AutoSize = true;
            this.lbl_min_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_min_5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_min_5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_min_5.Location = new System.Drawing.Point(590, 344);
            this.lbl_min_5.Name = "lbl_min_5";
            this.lbl_min_5.Size = new System.Drawing.Size(77, 32);
            this.lbl_min_5.TabIndex = 18;
            this.lbl_min_5.Text = "Date2";
            // 
            // lbl_min_4
            // 
            this.lbl_min_4.AutoSize = true;
            this.lbl_min_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_min_4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_min_4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_min_4.Location = new System.Drawing.Point(437, 344);
            this.lbl_min_4.Name = "lbl_min_4";
            this.lbl_min_4.Size = new System.Drawing.Size(77, 32);
            this.lbl_min_4.TabIndex = 17;
            this.lbl_min_4.Text = "Date2";
            // 
            // lbl_min_3
            // 
            this.lbl_min_3.AutoSize = true;
            this.lbl_min_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_min_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_min_3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_min_3.Location = new System.Drawing.Point(289, 344);
            this.lbl_min_3.Name = "lbl_min_3";
            this.lbl_min_3.Size = new System.Drawing.Size(77, 32);
            this.lbl_min_3.TabIndex = 16;
            this.lbl_min_3.Text = "Date2";
            // 
            // lbl_min_2
            // 
            this.lbl_min_2.AutoSize = true;
            this.lbl_min_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_min_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_min_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_min_2.Location = new System.Drawing.Point(150, 344);
            this.lbl_min_2.Name = "lbl_min_2";
            this.lbl_min_2.Size = new System.Drawing.Size(77, 32);
            this.lbl_min_2.TabIndex = 15;
            this.lbl_min_2.Text = "Date2";
            // 
            // lbl_day_5
            // 
            this.lbl_day_5.AutoSize = true;
            this.lbl_day_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_day_5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_day_5.Location = new System.Drawing.Point(590, 278);
            this.lbl_day_5.Name = "lbl_day_5";
            this.lbl_day_5.Size = new System.Drawing.Size(77, 32);
            this.lbl_day_5.TabIndex = 13;
            this.lbl_day_5.Text = "Date5";
            // 
            // lbl_day_4
            // 
            this.lbl_day_4.AutoSize = true;
            this.lbl_day_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_day_4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_day_4.Location = new System.Drawing.Point(437, 278);
            this.lbl_day_4.Name = "lbl_day_4";
            this.lbl_day_4.Size = new System.Drawing.Size(77, 32);
            this.lbl_day_4.TabIndex = 12;
            this.lbl_day_4.Text = "Date4";
            // 
            // lbl_day_3
            // 
            this.lbl_day_3.AutoSize = true;
            this.lbl_day_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_day_3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_day_3.Location = new System.Drawing.Point(289, 278);
            this.lbl_day_3.Name = "lbl_day_3";
            this.lbl_day_3.Size = new System.Drawing.Size(77, 32);
            this.lbl_day_3.TabIndex = 11;
            this.lbl_day_3.Text = "Date3";
            // 
            // lbl_day_2
            // 
            this.lbl_day_2.AutoSize = true;
            this.lbl_day_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_day_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_day_2.Location = new System.Drawing.Point(153, 278);
            this.lbl_day_2.Name = "lbl_day_2";
            this.lbl_day_2.Size = new System.Drawing.Size(77, 32);
            this.lbl_day_2.TabIndex = 10;
            this.lbl_day_2.Text = "Date2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(35, 412);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 32);
            this.label25.TabIndex = 9;
            this.label25.Text = "Max";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label26.Location = new System.Drawing.Point(38, 344);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 32);
            this.label26.TabIndex = 8;
            this.label26.Text = "Min";
            // 
            // lbl_humil
            // 
            this.lbl_humil.AutoSize = true;
            this.lbl_humil.BackColor = System.Drawing.Color.Transparent;
            this.lbl_humil.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_humil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_humil.Location = new System.Drawing.Point(38, 190);
            this.lbl_humil.Name = "lbl_humil";
            this.lbl_humil.Size = new System.Drawing.Size(78, 32);
            this.lbl_humil.TabIndex = 7;
            this.lbl_humil.Text = "Humil";
            // 
            // lbl_wind
            // 
            this.lbl_wind.AutoSize = true;
            this.lbl_wind.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wind.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_wind.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_wind.Location = new System.Drawing.Point(38, 146);
            this.lbl_wind.Name = "lbl_wind";
            this.lbl_wind.Size = new System.Drawing.Size(70, 32);
            this.lbl_wind.TabIndex = 6;
            this.lbl_wind.Text = "Wind";
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_day.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_day.Location = new System.Drawing.Point(473, 61);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(77, 46);
            this.lbl_day.TabIndex = 5;
            this.lbl_day.Text = "Day";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(649, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 107);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cityName.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cityName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_cityName.Location = new System.Drawing.Point(0, 0);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(183, 46);
            this.lbl_cityName.TabIndex = 0;
            this.lbl_cityName.Text = "Aluthgama";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.BackColor = System.Drawing.Color.Transparent;
            this.lbl_country.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_country.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_country.Location = new System.Drawing.Point(0, 46);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(46, 37);
            this.lbl_country.TabIndex = 1;
            this.lbl_country.Text = "LK";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_temp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_temp.Location = new System.Drawing.Point(473, 0);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(41, 46);
            this.lbl_temp.TabIndex = 3;
            this.lbl_temp.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1174, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_wind_2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_max_5;
        private System.Windows.Forms.Label lbl_max_4;
        private System.Windows.Forms.Label lbl_max_3;
        private System.Windows.Forms.Label lbl_max_2;
        private System.Windows.Forms.Label lbl_min_5;
        private System.Windows.Forms.Label lbl_min_4;
        private System.Windows.Forms.Label lbl_min_3;
        private System.Windows.Forms.Label lbl_min_2;
        private System.Windows.Forms.Label lbl_day_5;
        private System.Windows.Forms.Label lbl_day_4;
        private System.Windows.Forms.Label lbl_day_3;
        private System.Windows.Forms.Label lbl_day_2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbl_humil;
        private System.Windows.Forms.Label lbl_wind;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_cityName;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label lbl_day;
    }
}

