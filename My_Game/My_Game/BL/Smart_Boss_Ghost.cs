using Space_Shooters.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_Game.BL
{
    public class Smart_Boss_Ghost:Ghost
    {
        Game_Direction direction;
        Space_Shooter_Player player;
        int speed = 0;
        bool flag=false;

        public bool Flag { get => flag; set => flag = value; }

        public Smart_Boss_Ghost(Image image, Game_Cell cell,Space_Shooter_Player player) : base(image, cell)
        {
            this.Current_cell = cell;
            this.player = player;
        }
        public override Game_Cell Move()
        {
            Game_Cell currentCell = this.Current_cell;
            Game_Cell nextCell = currentCell.next(direction);

            if (speed % 5 == 0)
            {
                if (nextCell.Currentobj.Type == Game_Object_Type.Fire)
                {
                    Flag = true;
                }

                if (currentCell == nextCell)
                {
                    Set();
                }

                if (currentCell != nextCell)
                {
                    Set();
                    currentCell.Set_Game_Object(nextCell.Currentobj);
                    this.Current_cell = nextCell;
                    return nextCell;

                }
                return nextCell;
            }

            speed++;
            return this.Current_cell;
        }
        public void Set()
        {
            if (player.Current_cell.Rows > this.Current_cell.Rows)
            {
                direction = Game_Direction.Down;
            }
            if (player.Current_cell.Rows < this.Current_cell.Rows)
            {
                direction = Game_Direction.Up;
            }
            if (player.Current_cell.Cols > this.Current_cell.Cols)
            {
                direction = Game_Direction.Right;
            }
            if (player.Current_cell.Rows < this.Current_cell.Rows)
            {
                direction = Game_Direction.Left;
            }
        }
        public override bool Get_Flag()
        {
            return this.Flag;
        }
        public override bool Collision(Space_Shooter_Player player)
        {
            if (Game_Object_Type.PLAYER == this.Current_cell.Currentobj.Type)
            {
                return true;
            }
            return false;
        }
    }
}
