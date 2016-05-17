using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_Group_Project.Models
{
    [Table("GameModels")]
    public class GameModel
    {
        [Key]
        public int GameModelId { get; set; }
        private string _question { get; set; }
        private string _answer { get; set; }

        public GameModel(string question, string answer)
        {
            _question = question;
            _answer = answer;
        }

        public static Dictionary<string, string> TriviaCall()
        {
            var client = new RestClient();



            client.BaseUrl = new Uri("http://jservice.io/api/clues");

            var request = new RestRequest();
            IRestResponse response = client.Execute(request);

            dynamic dyn = JsonConvert.DeserializeObject(response.Content);

            Random rnd = new Random();
            int correct = rnd.Next(1, 50);
            int random1 = rnd.Next(1, 50);
            int random2 = rnd.Next(1, 50);
            int random3 = rnd.Next(1, 50);


            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("question", dyn[correct].question.ToString());
            myDictionary.Add("correctAnswer", dyn[correct].answer.ToString());
            myDictionary.Add("otherAnswer1", dyn[random1].answer.ToString());
            myDictionary.Add("otherAnswer2", dyn[random2].answer.ToString());
            myDictionary.Add("otherAnswer3", dyn[random3].answer.ToString());


            return myDictionary;
        }
    }
}
