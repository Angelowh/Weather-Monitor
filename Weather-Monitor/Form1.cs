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
        string cityName;
        string myIP;

        public Form1()
        {
            InitializeComponent();
            getLocalById(myIP);
            getWeather(cityName);
            getForcast(cityName);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txt_cityName.Text != null && txt_cityName.Text != "")
            {
                cityName = txt_cityName.Text;
                getWeather(cityName);
                getForcast(cityName);
            }
            else
            {
                MessageBox.Show("Erro ao localizar a cidade", "Digite uma cidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getID()
        {
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress adress in localIP)
            {
                myIP = adress.ToString();
            }
        }

        void getLocalById(string id)
        {
            using (WebClient web = new WebClient()) 
            {
                string token = "9fcbb16caceacc";
                string url = string.Format("http://ipinfo.io/{0}?token={1}", id, token);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<IpInfo.root>(json);

                IpInfo.root output = result;

                cityName = string.Format("{0}", output.city);
                lbl_ip.Text = string.Format("{0}", output.ip);
            }
        }

        void getWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&lang=pt_br", city, APPID);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root outPut = result;

                lbl_cityName.Text = string.Format("{0}", outPut.name);
                lbl_country.Text = string.Format("{0}", outPut.sys.country);
                lbl_temp.Text = string.Format("{0} \u00B0" + "C", outPut.main.temp);
                lbl_day.Text = string.Format("{0}", getDate(outPut.dt).DayOfWeek);
                lbl_wind.Text = string.Format("Wind: {0} km/h", outPut.wind.speed);
                lbl_humil.Text = string.Format("Humidity: {0} %", outPut.main.humidity);           
            }
        }

        void getForcast(string city)
        {
            int day = 5 ;
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&cnt={1}&units=metric&appid={2}", city, day, APPID);
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<weatherForcast>(json);

                weatherForcast forcast = Object;

                lbl_day_2.Text = string.Format("{0}", getDate(forcast.list[1].dt).TimeOfDay);
                lbl_day_3.Text = string.Format("{0}", getDate(forcast.list[2].dt).TimeOfDay);
                lbl_day_4.Text = string.Format("{0}", getDate(forcast.list[3].dt).TimeOfDay);
                lbl_day_5.Text = string.Format("{0}", getDate(forcast.list[4].dt).TimeOfDay);

                lbl_min_2.Text = string.Format("{0} \u00B0" + "C", forcast.list[1].main.temp_min);
                lbl_min_3.Text = string.Format("{0} \u00B0" + "C", forcast.list[2].main.temp_min);
                lbl_min_4.Text = string.Format("{0} \u00B0" + "C", forcast.list[3].main.temp_min);
                lbl_min_5.Text = string.Format("{0} \u00B0" + "C", forcast.list[4].main.temp_min);

                lbl_max_2.Text = string.Format("{0} \u00B0" + "C", forcast.list[1].main.temp_max);
                lbl_max_3.Text = string.Format("{0} \u00B0" + "C", forcast.list[1].main.temp_max);
                lbl_max_4.Text = string.Format("{0} \u00B0" + "C", forcast.list[1].main.temp_max);
                lbl_max_5.Text = string.Format("{0} \u00B0" + "C", forcast.list[1].main.temp_max);
                
                /*lbl_cond_2.Text = string.Format("{0}", forcast.list[1].weather[0].main);
                lbl_des_2.Text = string.Format("{0}", forcast.list[1].weather[0].description);
                lbl_temp_2.Text = string.Format("{0}\u00B0" + "C", forcast.list[1].main.temp);
                lbl_wind_2.Text = string.Format("{0} km/h", forcast.list[1].wind.speed);

                lbl_day_3.Text = string.Format("{0}", getDate(forcast.list[2].dt).DayOfWeek);
                lbl_cond_3.Text = string.Format("{0}", forcast.list[2].weather[0].main);
                lbl_des_3.Text = string.Format("{0}", forcast.list[2].weather[0].description);
                lbl_temp_3.Text = string.Format("{0}\u00B0" + "C", forcast.list[2].main.temp);
                lbl_wind_3.Text = string.Format("{0} km/h", forcast.list[2].wind.speed);*/

            }
        }

        DateTime getDate(double millisecound)
        {

            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecound).ToLocalTime();

            return day;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
