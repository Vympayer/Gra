using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    class Figury
    {
        private
        int pos_x;
        int pos_y;
        int height;
        int width;
        public
            int get_pos_x()
        {
            return pos_x;
        }
        int get_pos_y()
        {
            return pos_y;
        }
        int get_height()
        { return height; }
        int get_width()
        { return width; }
        void set_pos_x(int a)
        {
            pos_x = a;
        }
        void set_pos_y(int a)
        {
            pos_y = a;
        }
        void set_height(int a)
        {
            height = a;
        }
        void set_width(int a)
        {
            width = a;
        }
    }
}
