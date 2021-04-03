
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
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_day_2 = new System.Windows.Forms.Label();
            this.lbl_cond_2 = new System.Windows.Forms.Label();
            this.lbl_des_2 = new System.Windows.Forms.Label();
            this.lbl_wind_2 = new System.Windows.Forms.Label();
            this.lbl_temp_2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cityName.Location = new System.Drawing.Point(26, 36);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(323, 46);
            this.lbl_cityName.TabIndex = 0;
            this.lbl_cityName.Text = "Aluthgama, Western";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_country.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_country.Location = new System.Drawing.Point(26, 82);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(46, 37);
            this.lbl_country.TabIndex = 1;
            this.lbl_country.Text = "LK";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_temp.Location = new System.Drawing.Point(173, 154);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(41, 46);
            this.lbl_temp.TabIndex = 3;
            this.lbl_temp.Text = "C";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 107);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(716, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_day_2
            // 
            this.lbl_day_2.AutoSize = true;
            this.lbl_day_2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_day_2.Location = new System.Drawing.Point(829, 82);
            this.lbl_day_2.Name = "lbl_day_2";
            this.lbl_day_2.Size = new System.Drawing.Size(74, 37);
            this.lbl_day_2.TabIndex = 6;
            this.lbl_day_2.Text = "Days";
            // 
            // lbl_cond_2
            // 
            this.lbl_cond_2.AutoSize = true;
            this.lbl_cond_2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cond_2.Location = new System.Drawing.Point(829, 119);
            this.lbl_cond_2.Name = "lbl_cond_2";
            this.lbl_cond_2.Size = new System.Drawing.Size(99, 28);
            this.lbl_cond_2.TabIndex = 7;
            this.lbl_cond_2.Text = "Condition";
            // 
            // lbl_des_2
            // 
            this.lbl_des_2.AutoSize = true;
            this.lbl_des_2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_des_2.Location = new System.Drawing.Point(829, 154);
            this.lbl_des_2.Name = "lbl_des_2";
            this.lbl_des_2.Size = new System.Drawing.Size(112, 28);
            this.lbl_des_2.TabIndex = 8;
            this.lbl_des_2.Text = "Description";
            // 
            // lbl_wind_2
            // 
            this.lbl_wind_2.AutoSize = true;
            this.lbl_wind_2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_wind_2.Location = new System.Drawing.Point(981, 82);
            this.lbl_wind_2.Name = "lbl_wind_2";
            this.lbl_wind_2.Size = new System.Drawing.Size(116, 37);
            this.lbl_wind_2.TabIndex = 9;
            this.lbl_wind_2.Text = "12 km/h";
            // 
            // lbl_temp_2
            // 
            this.lbl_temp_2.AutoSize = true;
            this.lbl_temp_2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_temp_2.Location = new System.Drawing.Point(981, 144);
            this.lbl_temp_2.Name = "lbl_temp_2";
            this.lbl_temp_2.Size = new System.Drawing.Size(47, 37);
            this.lbl_temp_2.TabIndex = 10;
            this.lbl_temp_2.Text = "26";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(716, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 46);
            this.label6.TabIndex = 11;
            this.label6.Text = "Previsão";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 507);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_temp_2);
            this.Controls.Add(this.lbl_wind_2);
            this.Controls.Add(this.lbl_des_2);
            this.Controls.Add(this.lbl_cond_2);
            this.Controls.Add(this.lbl_day_2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_cityName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cityName;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_day_2;
        private System.Windows.Forms.Label lbl_cond_2;
        private System.Windows.Forms.Label lbl_des_2;
        private System.Windows.Forms.Label lbl_wind_2;
        private System.Windows.Forms.Label lbl_temp_2;
        private System.Windows.Forms.Label label6;
    }
}

