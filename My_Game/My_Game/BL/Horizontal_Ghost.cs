using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Shooters.BL
{
    public class Horizontal_Ghost : Ghost
    {
        Game_Direction direction;
        bool flag = false;
        public Horizontal_Ghost(Image image, Game_Cell cell, Game_Direction d) : base(image, cell)
        {
            this.direction = d;
            this.Current_cell = cell;
        }

        public bool Flag { get => flag; set => flag = value; }

        public override Game_Cell Move()
        {
            Game_Cell currentCell = this.Current_cell;
            Game_Cell next = currentCell.next(direction);

            if (next.Currentobj.Type == Game_Object_Type.Fire)
            {
                Flag = true;
            }

            if (currentCell == next)
            {
                ChangeDirection();
            }
            else
            {
                currentCell.Set_Game_Object(next.Currentobj);
                this.Current_cell = next;
                return next;
            }

            return null;
        }

        private void ChangeDirection()
        {
            if (this.direction == Game_Direction.Left)
            {
                this.direction = Game_Direction.Right;
            }
            else if (this.direction == Game_Direction.Right)
            {
                this.direction = Game_Direction.Left;
            }
        }

        public override bool Get_Flag()
        {
            return this.Flag;
        }

        public override bool Collision(Space_Shooter_Player player)
        {
            return (Game_Object_Type.PLAYER == this.Current_cell.Currentobj.Type);
        }

    }
}
