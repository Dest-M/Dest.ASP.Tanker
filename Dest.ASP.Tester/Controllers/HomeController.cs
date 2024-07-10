using Dest.ASP.Tester.Game;
using Dest.ASP.Tester.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Permissions;

namespace Dest.ASP.Tester.Controllers
{
    public class HomeController(IGameManager _gameManager) : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Security() { 
            return View();
        }

        public IActionResult LogInORSignUp()
        {
            return View();
        }
        public IActionResult Gamescreen()
        {
            var game = _gameManager.GetGameTanks(null);
            var dataModel = new GameModel(game);

            return View(dataModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
