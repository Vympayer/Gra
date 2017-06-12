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
    }
}
