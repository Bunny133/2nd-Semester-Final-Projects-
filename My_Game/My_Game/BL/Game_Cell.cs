using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooters.BL
{
    public class Game_Cell
    {
        int rows;
        int cols;
        Game_Object currentobj;
        private PictureBox pictureBox;
        public Game_Grid grid;
        const int width = 70;
        const int height = 70;

        public int Rows { get => rows; set => rows = value; }
        public int Cols { get => cols; set => cols = value; }
        public Game_Object Currentobj { get => currentobj; set => currentobj = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }

        public Game_Cell(int rows, int cols, Game_Grid grid)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.grid = grid;
            PictureBox = new PictureBox();
            PictureBox.Left = cols * width;
            PictureBox.Top = rows * height;
            PictureBox.BackColor = Color.Transparent;
            PictureBox.Size = new Size(width, height);
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void Set_Game_Object(Game_Object gameobject)
        {
            Currentobj = gameobject;
            PictureBox.Image = gameobject.Image;
        }
        public Game_Cell next(Game_Direction direction)
        {
            if (direction == Game_Direction.Left)
            {
                if (this.Cols > 0)
                {
                    Game_Cell ncell = Game_Grid.Get_Cell(this.rows, this.cols - 1);
                    if (ncell.Currentobj.Type != Game_Object_Type.WALL)
                    {
                        return ncell;
                    }
                }
            }
            if (direction == Game_Direction.Right)
            {
                if (this.Cols < grid.cols - 1)
                {
                    Game_Cell ncell = Game_Grid.Get_Cell(this.rows, this.cols + 1);
                    if (ncell.Currentobj.Type != Game_Object_Type.WALL)
                    {
                        return ncell;
                    }
                }
            }
            if (direction == Game_Direction.Up)
            {
                if (this.rows > 0)
                {
                    Game_Cell ncell = Game_Grid.Get_Cell(this.rows - 1, this.cols);
                    if (ncell.Currentobj.Type != Game_Object_Type.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == Game_Direction.Down)
            {
                if (this.rows < grid.rows - 1)
                {
                    Game_Cell ncell = Game_Grid.Get_Cell(this.rows + 1, this.cols);
                    if (ncell.Currentobj.Type != Game_Object_Type.WALL)
                    {
                        return ncell;
                    }
                }
            }
            return this;
        }
    }
}
