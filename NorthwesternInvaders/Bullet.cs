using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NorthwesternInvaders
{
    public class Bullet
    {
        public int x, y, width, height, speed;
        public string direction;
        public Rectangle hb;

        

        public Bullet(int _x, int _y, int _width, int _height, int _speed)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            hb = new Rectangle(x, y, width, height);

        }
    }
}
