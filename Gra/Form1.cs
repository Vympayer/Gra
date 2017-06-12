
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Form1 : Form
    {
        private Figury[] Bricks = new Figury[28];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void generate_bricks(Figury[] a)
        { int LICZBA_RZEDOW = 4;
            int ELEMENT_RZAD = 7;
            int BRICk_HEIGHT = 10;
            int BRICK_WIDTH = 20;

            for (int i = 0; i < LICZBA_RZEDOW; i++)
                for (int j = 0; j < ELEMENT_RZAD; j++)
                { a[i + j].set_height(BRICk_HEIGHT);
                    a[i + j].set_width(BRICK_WIDTH);

                }
        }
    }
}
