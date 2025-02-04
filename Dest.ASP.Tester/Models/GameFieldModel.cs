﻿using Dest.ASP.Tester.Game;
using Dest.ASP.Tester.Models.Enums;
using System.Diagnostics.Metrics;

namespace Dest.ASP.Tester.Models
{
    public class GameFieldModel
    {
        public  int FieldWidth => 15;
        public int FieldHeight => 15; 
        public CellTile[][] Map { get; private set; }

        public GameFieldModel(IGameTanks game)
        {
            Map = initialiseMap();
            GenerateMap();
        }

        private void GenerateMap()
        {
            GenerateBrickCells(30);
            GenerateBedrock();

           
            Map[0][FieldWidth / 2] = CellTile.EnemyBase;
            Map[^1][FieldWidth / 2] = CellTile.FriendlyBase;
        }

        private void GenerateBedrock()
        {
            for (int row = 2; row < FieldHeight-2; row+=2)
            {
                for (int col = 2; col < FieldWidth -2; col+=2)
                {
                    Map[row][col] = CellTile.Bedrock;
                }
            }
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
            CellTile [][]map = new CellTile[FieldHeight][];

            for (int counter = 0; counter < FieldHeight; counter++)
            {
                map[counter] = new CellTile[FieldWidth];
                Array.Fill(map[counter], CellTile.Empty);
            }
            return map;
        }



    }
}
