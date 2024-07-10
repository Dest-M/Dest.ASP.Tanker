using Dest.ASP.Tester.Game;
using Dest.ASP.Tester.Models.Enums;
using System.Diagnostics.Metrics;

namespace Dest.ASP.Tester.Models
{
    public class GameFieldModel
    {
        public  int FieldWidth => 20;
        public int FieldHeight => 20; 
        public CellTile[][] Map { get; private set; }

        public GameFieldModel(IGameTanks game)
        {
            Map = initialiseMap();
            GenerateMap();
        }

        private void GenerateMap()
        {
            GenerateBrickCells(60);
        }

        private void GenerateBrickCells(int fillPercent)
        {
            Random random = new Random();
            for(int row = 0; row < FieldHeight; row++)
            {
                for(int col = 0; col < FieldWidth; col++)
                {
                    int randomValue = random.Next(0, 100);

                    if(randomValue <= fillPercent)
                    {
                        Map[row][col] = CellTile.Brick;
                    }
                }
            }
        }

        private CellTile[][] initialiseMap()
        {
            CellTile [][]Map = new CellTile[FieldHeight][];

            for (int counter = 0; counter < FieldHeight; counter++)
            {
                Map[FieldHeight] = new CellTile[FieldWidth];
                Array.Fill(Map[counter], CellTile.Empty);
            }
            return Map;
        }



    }
}
