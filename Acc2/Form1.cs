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
                    double.TryParse(weather.Main.Температура.ToString(), out double temperatureValue);
                    double.TryParse(weather.Main.Влажность.ToString(), out double humidityValue);
                    double.TryParse(weather.Main.Давление.ToString(), out double pressureValue);

                    double temperatureRounded = Math.Round(temperatureValue, 2);
                    double humidityRounded = Math.Round(humidityValue, 2);
                    double pressureRounded = Math.Round(pressureValue, 2);

                    temperature.Text = $"Температура в городе {cityName.Text} - {temperatureRounded}";
                    humidity.Text = $"Влажность в городе {cityName.Text} - {humidityRounded}";
                    pressure.Text = $"Давление в городе {cityName.Text} - {pressureRounded}";



                    switch (weather.WeatherList.First().Description)
                    {
                        case "облачно с прояснениями":
                            weatherInfo.Text = "На улице облачно с прояснениями";
                            weatherIcon.Image = Properties.Resources.cloudy;
                            break;
                        case "снег":
                            weatherInfo.Text = "На улице идёт снег";
                            weatherIcon.Image = Properties.Resources.snowy;
                            break;
                        case "пасмурно":
                            weatherInfo.Text = "На улице пасмурно";
                            weatherIcon.Image = Properties.Resources.cloudy;
                            break;
                        case "ясно":
                            weatherInfo.Text = "На улице ясно";
                            weatherIcon.Image = Properties.Resources.clear;
                            break;
                    }
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите сохранить данные о погоде города в файл?", "Message", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                var path = $"{cityName.Text}.json";
                var json = JsonSerializer.Serialize(weather);
                File.WriteAllText(path, json);
            }
        }
    }
}
