using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using Trivia_Group_Project.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Trivia_Group_Project.Controllers
{
    public class HomeController1 : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            var question = GameModel.TriviaCall();
            return View(question);
        }

        public IActionResult Answers()
        {
            var question = GameModel.TriviaCall();
            return View(question);
        }

        //Post /Game
        [HttpPost]
        [HttpPost, ActionName("Index")]
        public IActionResult Game()
        {


            string userAnswer = Request.Form["answer"];
            Console.WriteLine(userAnswer);


            //Console.WriteLine(dyn.question);
            //Console.WriteLine("Hello World");
            //1
            //var request = new RestRequest("Accounts/{{Account SID}}/Messages.json", Method.GET);
            //client.Authenticator = new HttpBasicAuthenticator("{{Account SID}}", "{{Auth Token}}");
            ////2
            //var response = client.Execute(request);
            //var answer = Request.Form["answer"];
            return View();
        }

        //[HttpPost]
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
