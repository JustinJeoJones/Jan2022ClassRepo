using Newtonsoft.Json;
using System.Net;

namespace ApiLecture.Models
{
    public class StarwarsDAL
    {

        public StarwarsCharacter GetStarwarsCharacter(int id)
        {
            string url = $"https://swapi.dev/api/people/{id}";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            StarwarsCharacter result = JsonConvert.DeserializeObject<StarwarsCharacter>(JSON);
            return result;
        }

        public StarwarsCharacter SearchStarwarsCharacter(string name)
        {
            string url = $"https://swapi.dev/api/people/?search={name}";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            NameSearch result = JsonConvert.DeserializeObject<NameSearch>(JSON);
            return result.results[0];
        }

    }
}
