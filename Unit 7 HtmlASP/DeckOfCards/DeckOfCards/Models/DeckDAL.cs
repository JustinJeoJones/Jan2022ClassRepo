using Newtonsoft.Json;
using System.Net;

namespace DeckOfCards.Models
{
    public class DeckDAL
    {
        public DeckModel GetCards()
        {
            string url = $"https://deckofcardsapi.com/api/deck/gd1xv1k43de9/draw/?count=5";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(JSON);

            return result;
        }

        public void ShuffleCards()
        {
            string url = $"https://deckofcardsapi.com/api/deck/gd1xv1k43de9/shuffle/";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }
    }
}
