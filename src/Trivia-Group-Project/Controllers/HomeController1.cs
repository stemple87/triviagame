using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using Trivia_Group_Project.Models;
using Microsoft.AspNet.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Trivia_Group_Project.Controllers
{
    public class HomeController1 : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController1(
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext db
        )
        {
            _userManager = userManager;
            _db = db;
        }
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

            return View();

        }

        ////Post /Game /Alternate
        //[HttpPost]
        //[HttpPost, ActionName("Index")]
        //public async Task<IActionResult> Game()
        //{
        //    //this needs to be fixed
        //    var currentUser = await _userManager.FindByIdAsync(User.GetUserId());
        //    return View(_db.Players.Where(x => x.User.Id == currentUser.Id));



        //}

    }
}
