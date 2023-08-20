using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Shooters.BL
{
    public class Game
    {


        public static Image ResizeImage(Image originalImage, int newWidth, int newHeight)
        {
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        public static Image GetResizedShipImage(int newWidth, int newHeight)
        {
            Image shipImage = My_Game.Properties.Resources.Ship;
            return ResizeImage(shipImage, newWidth, newHeight);
        }



        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = My_Game.Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = My_Game.Properties.Resources.vertical2;
            }

            if (displayCharacter == '#')
            {
                img = My_Game.Properties.Resources.horizontal;
            }
            if (displayCharacter == 'S' || displayCharacter == 's')
            {
                img= My_Game.Properties.Resources.images__1___1__removebg_preview;


            }
            if (displayCharacter == 'E')
            {
                img = My_Game.Properties.Resources.Ghost;
            }
            if (displayCharacter == 'e')
            {
                img = My_Game.Properties.Resources.Ghost2;
            }
            if (displayCharacter == 'R')
            {
                img = My_Game.Properties.Resources.Enemy;
            }
            if (displayCharacter == 'B' || displayCharacter == 'b')
            {
                img = My_Game.Properties.Resources._27803_91fd7c56c0817b211ea4827f9d6b324e;
            }
            if (displayCharacter == '.')
            {
                img = My_Game.Properties.Resources.laserRed13;
            }
            if (displayCharacter == ' ')
            {
                img = My_Game.Properties.Resources.transparent1;
            }
            if (displayCharacter == '.')
            {
                img = My_Game.Properties.Resources.laserRed13;
            }
            if (displayCharacter == '*')
            {
                img = My_Game.Properties.Resources.bullet;
            }
            return img;
        }

        public static Game_Object Get_Blank()
        {
            Game_Object blankGameObject = new Game_Object(Game_Object_Type.NONE, My_Game.Properties.Resources.transparent1);
            return blankGameObject;
        }

       
    }
}
