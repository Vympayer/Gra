
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
        Figury ball;
        Figury paletka;
        int speed_up;
        int speed_right;

        public Form1()
        {
            Timer timer1 = new Timer();
            timer1.Interval = 20;
            timer1.Start();
            timer1.Tick += UpdateScreen;
            speed_up = 2;
            speed_right = 2;
            InitializeComponent();
            StartGame();
            generate_bricks();
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

        }

       private void Form1_Load(object sender, EventArgs e) { }
        private void StartGame()
        {

            ball = new Figury(300, 300, 50, 50);
            paletka = new Figury(480, 600, 20, 100);
           

           

        }
        private void generate_bricks()
        {



            for (int j = 0; j < 40; j++)
                cegielki[j] = 1;

            

                
            // a[7] = null; 
        }

        private void UpdateScreen(object sender, EventArgs e)

        {

           if ((paletka.right==1)&&(paletka.moving==true))
                paletka.set_pos_x(paletka.get_pos_x() + 5); // Zepsułem i się rusza
            if ((paletka.right == -1)&&(paletka.moving==true))
                paletka.set_pos_x(paletka.get_pos_x() - 5); // Zepsułem i się rusza

            ball.set_pos_x(ball.get_pos_x() + speed_right);
            ball.set_pos_y(ball.get_pos_y() + speed_up);

            wykryj_kolizje();

            pictureBox1.Invalidate();

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

       
        private void Nowa_Gra_Click(object sender, EventArgs e)
        {
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {  
            
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paletka.moving = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            paletka.moving = true;
            paletka.right = -1;
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            paletka.moving = true;
            paletka.right = 1;
        }

        private void wykryj_kolizje()
        {
            

         
              
            if (((ball.get_pos_y() <= paletka.get_pos_y()) && (ball.get_pos_y()+50 >= paletka.get_pos_y())) && ((ball.get_pos_x() >= paletka.get_pos_x()) && (ball.get_pos_x() <= paletka.get_pos_x()+100)))    //kolizja z rakieta
            {
               
                speed_up = -speed_up;                                                              
                
            }
            if (ball.get_pos_x() <= pictureBox1.Left)
            {
                speed_right = -speed_right;
            }

            if (ball.get_pos_x()+50 >= pictureBox1.Right)
            {
                speed_right = -speed_right;
            }
            if (ball.get_pos_y() <= pictureBox1.Top)
            {
                speed_right = -speed_up;
            }
            if (ball.get_pos_y()+50 <= pictureBox1.Bottom)
            {
                speed_up = -speed_up;
            }

            if ((paletka.get_pos_x() <= pictureBox1.Left) || (paletka.get_pos_x() >= pictureBox1.Right))
                paletka.moving = false;

        }
    }
}
