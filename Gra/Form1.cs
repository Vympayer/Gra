
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Size 1000X720
// Location 20X12
namespace Gra
{
    public partial class Form1 : Form
    {
        int[] cegielki = new int[40];
        Figury ball = new Figury(300, 300, 50, 50);
        Figury paletka = new Figury(480, 600, 20, 100);
        public Form1()
        {
            InitializeComponent();
            generate_bricks();
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void generate_bricks()
        {



            for (int j = 0; j < 40; j++)
                cegielki[j] = 1;
                   


                
            // a[7] = null; 
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

           
               
                    Brush BrickColour= Brushes.Red;


            int BRICk_HEIGHT = 45;
            int BRICK_WIDTH = 90;
            //Draw bricks
           
                 for (int j = 0; j < 40; j++)
                 { if (cegielki[j]==1)
                     canvas.FillRectangle(BrickColour,
                         new Rectangle(20+(BRICK_WIDTH+5)*(j%10),
                                         6+ (BRICk_HEIGHT+2) * (j / 10),
                                         BRICK_WIDTH, BRICk_HEIGHT));
                 }
            //Draw ball
            Brush ballcolour = Brushes.Blue;
            canvas.FillEllipse(ballcolour,
                       new Rectangle(ball.get_pos_x(),  
                                       ball.get_pos_y(),
                                       ball.get_width(), ball.get_height()));
            //Paletka
            Brush pcolor = Brushes.Black;
            canvas.FillRectangle(pcolor,
                       new Rectangle(paletka.get_pos_x(),
                                       paletka.get_pos_y(),
                                       paletka.get_width(), paletka.get_height()));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // pbCanvas to cały czas picturebox
        private void Nowa_Gra_Click(object sender, EventArgs e)
        {
            //pictureBox1.Invalidate();
            
        }
    }
}
