using Space_Shooters.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_Game.BL
{
    public class Random_Ghost : Ghost
    {
        bool flag = false;

        public bool Flag { get => flag; set => flag = value; }

        public Random_Ghost(Image image, Game_Cell cell) : base(image, cell)
        {
            this.Current_cell = cell;
        }

        public override Game_Cell Move()
        {
            Random random = new Random();
            int number = random.Next(10);

            if (number % 4 == 0)
                return MoveInDirection(Game_Direction.Down);

            if (number % 3 == 0)
                return MoveInDirection(Game_Direction.Up);

            if (number % 7 == 0)
                return MoveInDirection(Game_Direction.Right);

            if (number % 9 == 0)
                return MoveInDirection(Game_Direction.Left);

            return null;
        }

        private Game_Cell MoveInDirection(Game_Direction direction)
        {
            Game_Cell currentCell = this.Current_cell;
            Game_Cell nextCell = currentCell.next(direction);

            if (nextCell.Currentobj.Type == Game_Object_Type.Fire)
                Flag = true;

            if (nextCell.Currentobj.Type != Game_Object_Type.WALL && currentCell != nextCell)
            {
                currentCell.Set_Game_Object(nextCell.Currentobj);
                this.Current_cell = nextCell;
                return nextCell;
            }

            return null;
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

