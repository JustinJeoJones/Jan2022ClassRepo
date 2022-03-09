using Newtonsoft.Json;
using System.Net;

namespace ApiLecture.Models
{
    public class WeatherDAL
    {
        public WeatherModel GetWeather(string city)
        {
            string apiKey = "f13d9a4c716f47f7fa06bc732c55e049";
            string url = $"https://api.openweathermap.org/data/2.5/weather?appid={apiKey}&q={city}&units=imperial";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            WeatherModel result = JsonConvert.DeserializeObject<WeatherModel>(JSON);
            return result;
        }
    }
}
