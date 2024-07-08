using Dest.ASP.Tester.Game;

namespace Dest.ASP.Tester.Models
{
    public class GameModel
    {
        public GameFieldModel GameFieldModel { get; set; }
        public GameModel(IGameTanks game)
        {
            this.GameFieldModel = new GameFieldModel(game);
        }
    }
}
