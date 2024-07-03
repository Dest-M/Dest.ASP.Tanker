using Dest.ASP.Tester.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dest.ASP.Tester.Game
{
    public class GameController(IGameManager _gameManager) : Controller
    {
    

       
        public IActionResult Game() {
            var game = _gameManager.GetGameTanks(null);
            var dataModel = new GameModel(game);
            return View(dataModel);
        }

    }
}
