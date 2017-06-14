using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    class Figury
    {
        int pos_x;
        int pos_y;
        int height;
        int width;
        bool moving;
        int up;
        int right;
        
        
        public Figury(int a, int b, int c, int d, bool e, int f,int g) { pos_x = a; pos_y = b;height = c;width = d; right = f; moving = e; up = g; }
        public Figury() { pos_x = 10; pos_y = 10; height = 10; width = 10; right = 0; moving = false; up = 0; }

        public int get_pos_x()
        {
            return pos_x;
        }
        public int get_pos_y()
        {
            return pos_y;
        }
        public int get_height()
        { return height; }
        public int get_width()
        { return width; }
        public void set_pos_x(int a)
        {
            pos_x = a;
        }
        public void set_pos_y(int a)
        {
            pos_y = a;
        }
        public void set_height(int a)
        {
            height = a;
        }
        public void set_width(int a)
        {
            width = a;
        }
        public bool get_moving() { return moving; }
        public int get_up() { return up; }
        public int get_right() { return right; }
        public void set_moving(bool a) { moving = a; }
        public void set_up(int a) { up = a; }
        public void set_right(int a) { right = a; }
    }
}
