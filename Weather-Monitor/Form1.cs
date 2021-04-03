using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Weather_Monitor
{
    public partial class Form1 : Form
    {
        const string APPID = "cc530447ac61ef046f838eaafc3407c2";
        string cityName = "Colombo";
        public Form1()
        {
            InitializeComponent();
            getWeather("Paraipaba");
            getForcast("Paraipaba");
        }

        void getWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6&lang=pt_br", city, APPID);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root outPut = result;

                lbl_cityName.Text = string.Format("{0}", outPut.name);
                lbl_country.Text = string.Format("{0}", outPut.sys.country);
                lbl_temp.Text = string.Format("{0} \u00B0" + "C", outPut.main.temp);

            }
        }

        void getForcast(string city)
        {
            int day = 5;
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&cnt={1}&units=metric&lang=pt_br&appid={2}", city, day, APPID);
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<weatherForcast>(json);

                weatherForcast forcast = Object;

                lbl_day_2.Text = string.Format("{0}", getDate(forcast.list[1].dt).DayOfWeek);
                lbl_cond_2.Text = string.Format("{0}", forcast.list[1].weather[0].main);
                lbl_des_2.Text = string.Format("{0}", forcast.list[1].weather[0].description);
                lbl_temp_2.Text = string.Format("{0}\u00B0" + "C", forcast.list[1].main.temp);
                lbl_wind_2.Text = string.Format("{0} km/h", forcast.list[1].wind.speed);
            }
        }

        DateTime getDate(double millisecound)
        {

            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecound).ToLocalTime();

            return day;
        }

    }
}
