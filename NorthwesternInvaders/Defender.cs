using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NorthwesternInvaders
{
    public class Defender
    {
        public int x, y, width, height, speed;
        public string direction;
        public Rectangle hb;

        public Defender(int _x, int _y, int _width, int _height)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            hb = new Rectangle(x, y, width, height);
        
        }


        public void move(int speed, string direction)
        {
            if (direction == "left")
            {
                x = x - speed;
            }
            else if (direction == "right")
            {
                x = x + speed;
            }
            else if (direction == "down")
            {
                y = y - 1;
            }
            hb = new Rectangle(x, y, width, height);
        }
    }
}
