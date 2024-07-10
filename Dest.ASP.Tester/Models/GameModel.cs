using Dest.ASP.Tester.Game;

namespace Dest.ASP.Tester.Models
{
    public class GameModel
    {
        public GameFieldModel GameFieldModel { get; set; }
        public GameFightFieldModel GameFightFieldModel { get; set; }
        public GameModel(IGameTanks game)
        {
            this.GameFieldModel = new GameFieldModel(game);
            GameFightFieldModel = new GameFightFieldModel(game);
        }
    }
}
