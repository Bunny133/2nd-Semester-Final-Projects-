using Space_Shooters.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_Game.BL
{
   public class Firing:Game_Object
   {
        bool iscollision_Wall=false;
        bool iscollision_Player = false;
        bool iscollision_Enemy = false;
        bool iscollision_EnemyFire = false;
        bool iscollision_PlayerFire = false;
        public Firing(Image image, Game_Cell Cell,Game_Object_Type type) : base(type, image)
        {
            this.Current_cell = Cell;
        }

        public bool Iscollision { get => iscollision_Wall; set => iscollision_Wall = value; }
        public bool Iscollision_Player { get => iscollision_Player; set => iscollision_Player = value; }
        public bool Iscollision_Enemy { get => iscollision_Enemy; set => iscollision_Enemy = value; }
        public bool Iscollision_PlayerFire { get => iscollision_PlayerFire; set => iscollision_PlayerFire = value; }
        public bool Iscollision_EnemyFire { get => iscollision_EnemyFire; set => iscollision_EnemyFire = value; }


        public Game_Cell MoveBulletOfEnemy()
        {
            Game_Cell currentCell = this.Current_cell;
            Game_Cell nextCell = currentCell.next(Game_Direction.Down);

            if (nextCell != currentCell)
            {
                if (nextCell != null)
                {
                    currentCell.Set_Game_Object(Game.Get_Blank());
                    Current_cell = nextCell;
                    return nextCell;
                }
            }

            if (nextCell == currentCell)
            {
                HandleBulletCollision(currentCell);
            }

            if (nextCell != null && nextCell.Currentobj.Type == Game_Object_Type.WALL)
            {
                HandleWallCollision();
            }

            return null;
        }

        private void HandleBulletCollision(Game_Cell currentCell)
        {
            currentCell.Set_Game_Object(Game.Get_Blank());
            Iscollision = true;
        }

        private void HandleWallCollision()
        {
            Iscollision_PlayerFire = true;
        }

        public Game_Cell MoveBulletOfPlayer()
        {
            Game_Cell currentCell = this.Current_cell;
            Game_Cell nextCell = currentCell.next(Game_Direction.Up);

            if (nextCell != null && nextCell.Currentobj.Type == Game_Object_Type.ENEMY)
            {
                HandleEnemyCollision();
            }

            if (nextCell != currentCell)
            {
                if (nextCell != null)
                {
                    currentCell.Set_Game_Object(Game.Get_Blank());
                    Current_cell = nextCell;
                    return nextCell;
                }
            }

            if (nextCell == currentCell)
            {
                HandleBulletCollision(currentCell);
            }

            return null;
        }

        private void HandleEnemyCollision()
        {
            Iscollision_Enemy = true;
        }

       

    }
}
