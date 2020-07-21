using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace FlickrViewer
{
   public partial class OpenWeatherForm : Form
   {
        private const string appid = "";

        public OpenWeatherForm()
        {
            InitializeComponent();
        }

        private void forecastButton_Click(object sender, EventArgs e)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=Ogden&appid=f570b223ae802e75c976793d4b911ad9&units=imperial&cnt=6");

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root weather = result;
                tempTextBox.Text = string.Format("{0} \u00B0", weather.main.temp);
            }
        }
    }
}

