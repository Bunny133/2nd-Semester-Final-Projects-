using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Shooters.BL
{
    public class Game_Grid
    {
        public static Game_Cell[,] cells;
        public int rows;
        public int cols;

        public Game_Grid(string filename, int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            cells = new Game_Cell[rows, cols];
            this.loadGrid(filename);
        }
        public static Game_Cell Get_Cell(int x, int y)
        {
            return cells[x, y];
        }
        void loadGrid(string fileName)
        {

            StreamReader fp = new StreamReader("Maze.txt");
            string record;
            for (int row = 0; row < this.rows; row++)
            {
                record = fp.ReadLine();
                for (int col = 0; col < this.cols; col++)
                {
                    Game_Cell cell = new Game_Cell(row, col, this);
                    Char displayCharacter = record[col];
                    Game_Object_Type t = Game_Object.Get_Game_Object_Type(displayCharacter);
                    Image displayIamge = Game.getGameObjectImage(displayCharacter);
                    Game_Object gameObject = new Game_Object(t, displayIamge);
                    cell.Set_Game_Object(gameObject);
                    cells[row, col] = cell;
                }
            }

            fp.Close();
        }
    }
}
