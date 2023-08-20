using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Shooters.BL
{
    public abstract class Ghost : Game_Object
    {
        public Ghost(Image image, Game_Cell Cell) : base(Game_Object_Type.ENEMY, image)
        {

        }
        public int Health { get; set; }
        public abstract Game_Cell Move();
        public abstract bool Get_Flag();
        public abstract bool Collision(Space_Shooter_Player player);
    }
}
