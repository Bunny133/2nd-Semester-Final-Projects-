using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace Space_Shooters.BL
{
    public class Space_Shooter_Player : Game_Object
    {
        bool PLayer_Collide_Enemy_Fire = false;
        bool PLayer_Collide_Enemy = false;

        public bool PLayer_Collide_Enemy_Fire1 { get => PLayer_Collide_Enemy_Fire; set => PLayer_Collide_Enemy_Fire = value; }
        public bool PLayer_Collide_Enemy1 { get => PLayer_Collide_Enemy; set => PLayer_Collide_Enemy = value; }

        public Space_Shooter_Player(Image image, Game_Cell startCell) : base(Game_Object_Type.PLAYER, image)
        {
            this.Current_cell = startCell;
        }

        public bool Get_Flag()
        {
            return PLayer_Collide_Enemy_Fire1;
        }
        public bool Get_Flag2()
        {
            return PLayer_Collide_Enemy1;
        }

        private Space_Shooter_Player Get_Player()
        {
            return this;
        }
        public Game_Cell move(Game_Direction direction)
        {

            Game_Cell currentCell = this.Current_cell;
            Game_Cell nextCell = currentCell.next(direction);

            if (Current_cell.Currentobj.Type == Game_Object_Type.Enemy_Fire)
            {
                PLayer_Collide_Enemy_Fire1 = true;
            }

            if (Current_cell.Currentobj.Type == Game_Object_Type.ENEMY)
            {
                PLayer_Collide_Enemy1 = true;
            }

            this.Current_cell = nextCell;

            if (currentCell != nextCell)
            {
                currentCell.Set_Game_Object(Game.Get_Blank());
            }

            return nextCell;
        }
    }
}
