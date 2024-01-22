using Acc2.models;
using System.Text.Json;

namespace Acc2
{
    public partial class Form1 : Form
    {
        WeatherController weatherController = new WeatherController();
        Weather weather = new Weather();
        public Form1()
        {
            InitializeComponent();
        }

        private async void weatherGet_Click(object sender, EventArgs e)
        {
            if (cityName.Text.Length > 0)
            {
                var weather = await weatherController.getWeather(cityName.Text);
                if (weather != null)
                {
                    double.TryParse(weather.Main.�����������.ToString(), out double temperatureValue);
                    double.TryParse(weather.Main.���������.ToString(), out double humidityValue);
                    double.TryParse(weather.Main.��������.ToString(), out double pressureValue);

                    double temperatureRounded = Math.Round(temperatureValue, 2);
                    double humidityRounded = Math.Round(humidityValue, 2);
                    double pressureRounded = Math.Round(pressureValue, 2);

                    temperature.Text = $"����������� � ������ {cityName.Text} - {temperatureRounded}";
                    humidity.Text = $"��������� � ������ {cityName.Text} - {humidityRounded}";
                    pressure.Text = $"�������� � ������ {cityName.Text} - {pressureRounded}";



                    switch (weather.WeatherList.First().Description)
                    {
                        case "������� � ������������":
                            weatherInfo.Text = "�� ����� ������� � ������������";
                            weatherIcon.Image = Properties.Resources.cloudy;
                            break;
                        case "����":
                            weatherInfo.Text = "�� ����� ��� ����";
                            weatherIcon.Image = Properties.Resources.snowy;
                            break;
                        case "��������":
                            weatherInfo.Text = "�� ����� ��������";
                            weatherIcon.Image = Properties.Resources.cloudy;
                            break;
                        case "����":
                            weatherInfo.Text = "�� ����� ����";
                            weatherIcon.Image = Properties.Resources.clear;
                            break;
                    }
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�� ������ ��������� ������ � ������ ������ � ����?", "Message", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                var path = $"{cityName.Text}.json";
                var json = JsonSerializer.Serialize(weather);
                File.WriteAllText(path, json);
            }
        }
    }
}
