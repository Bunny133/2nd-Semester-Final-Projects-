using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Shooters.BL
{
    public class Game_Object
    {
        private char display_character;
        private Game_Object_Type type;
        private Game_Cell current_cell;
        private Image image;



        public Game_Object(Game_Object_Type type, Image image)
        {
            this.Type = type;
            this.Image = image;
        }

        public Game_Object(char display_character, Game_Object_Type type)
        {
            this.Display_character = display_character;
            this.Type = type;
        }

        public static Game_Object_Type Get_Game_Object_Type(char displayCharacter)
        {
            if (displayCharacter == '|' || displayCharacter == '%' || displayCharacter == '#')
            {
                return Game_Object_Type.WALL;
            }

            return Game_Object_Type.NONE;
        }

        public char Display_character { get => display_character; set => display_character = value; }
        public Game_Object_Type Type { get => type; set => type = value; }
        public Game_Cell Current_cell
        {
            get => current_cell; set
            {
                current_cell = value;
                current_cell.Set_Game_Object(this);
            }
        }
        public Image Image { get => image; set => image = value; }
    }
}
