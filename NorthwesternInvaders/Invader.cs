using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NorthwesternInvaders
{
    class Invader
    {
        public int x, y, width, height, speed;
        public bool invShoot;
        public string direction;
        
        
        public Invader(int _x, int _y, int _width, int _height, bool _invShoot, string _direction, int _speed)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            invShoot = _invShoot;
            direction = _direction;
            speed = _speed;
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
                y = y + speed;
            }
      
        }
    }
}
