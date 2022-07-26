using Newtonsoft.Json;
using System.Net;

namespace DeckOfCardsLab.Models
{
    public class CardsDAL
    {
        public CardsModel GetCards() //Adjust method name
        {
            //Adjust
            //api url
            string key = "mal5qf9c3vlp"; //this should be hidden
            string url = $"https://deckofcardsapi.com/api/deck/{key}/draw/?count=5";

            //setup request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //save response data
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust
            //Convert JSON to a C# object
            CardsModel result = JsonConvert.DeserializeObject<CardsModel>(JSON);
            return result;
        }

        public void ShuffleCards()
        {
            string key = "mal5qf9c3vlp";
            string url = $"https://deckofcardsapi.com/api/deck/{key}/shuffle/";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }
    }
}
