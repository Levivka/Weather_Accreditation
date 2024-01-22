namespace Acc2
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
            weatherGet = new Button();
            cityName = new TextBox();
            temperature = new Label();
            humidity = new Label();
            pressure = new Label();
            weatherInfo = new Label();
            weatherIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)weatherIcon).BeginInit();
            SuspendLayout();
            // 
            // weatherGet
            // 
            weatherGet.Location = new Point(296, 124);
            weatherGet.Name = "weatherGet";
            weatherGet.Size = new Size(109, 23);
            weatherGet.TabIndex = 0;
            weatherGet.Text = "Узнать погоду";
            weatherGet.UseVisualStyleBackColor = true;
            weatherGet.Click += weatherGet_Click;
            // 
            // cityName
            // 
            cityName.Location = new Point(279, 78);
            cityName.Name = "cityName";
            cityName.Size = new Size(150, 23);
            cityName.TabIndex = 1;
            // 
            // temperature
            // 
            temperature.AutoSize = true;
            temperature.Location = new Point(43, 198);
            temperature.Name = "temperature";
            temperature.Size = new Size(78, 15);
            temperature.TabIndex = 2;
            temperature.Text = "Температура";
            // 
            // humidity
            // 
            humidity.AutoSize = true;
            humidity.Location = new Point(43, 238);
            humidity.Name = "humidity";
            humidity.Size = new Size(67, 15);
            humidity.TabIndex = 3;
            humidity.Text = "Влажность";
            // 
            // pressure
            // 
            pressure.AutoSize = true;
            pressure.Location = new Point(43, 284);
            pressure.Name = "pressure";
            pressure.Size = new Size(60, 15);
            pressure.TabIndex = 4;
            pressure.Text = "Давление";
            // 
            // weatherInfo
            // 
            weatherInfo.AutoSize = true;
            weatherInfo.Location = new Point(325, 198);
            weatherInfo.Name = "weatherInfo";
            weatherInfo.Size = new Size(47, 15);
            weatherInfo.TabIndex = 5;
            weatherInfo.Text = "Погода";
            // 
            // weatherIcon
            // 
            weatherIcon.Location = new Point(296, 238);
            weatherIcon.Name = "weatherIcon";
            weatherIcon.Size = new Size(133, 116);
            weatherIcon.SizeMode = PictureBoxSizeMode.Zoom;
            weatherIcon.TabIndex = 6;
            weatherIcon.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(weatherIcon);
            Controls.Add(weatherInfo);
            Controls.Add(pressure);
            Controls.Add(humidity);
            Controls.Add(temperature);
            Controls.Add(cityName);
            Controls.Add(weatherGet);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)weatherIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button weatherGet;
        private TextBox cityName;
        private Label temperature;
        private Label humidity;
        private Label pressure;
        private Label weatherInfo;
        private PictureBox weatherIcon;
    }
}
