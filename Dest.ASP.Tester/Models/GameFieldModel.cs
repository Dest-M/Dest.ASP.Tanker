using Dest.ASP.Tester.Game;
using System.Diagnostics.Metrics;

namespace Dest.ASP.Tester.Models
{
    public class GameFieldModel
    {
        public  int FieldWidth => 20;
        public int FieldHeight => 20; 
        public int[][] Map { get; private set; }

        public GameFieldModel(IGameTanks game)
        {
            Map = initialiseMap();
        }

        private int[][] initialiseMap()
        {
            Map = new int[FieldHeight][];

            for (int counter = 0; counter < FieldHeight; counter++)
            {
                Map[FieldHeight] = new int[FieldWidth];
            }
            return Map;
        }



    }
}
