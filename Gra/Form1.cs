
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
        
        Figury ball;
        Figury paletka;
        
        /*
        int BRICk_HEIGHT = 45;
        int BRICK_WIDTH = 90;
        Cegielki[] cegielki=new Cegielki[40];
        */

        public Form1()
        {
            Timer timer1 = new Timer();
            timer1.Interval = 20;
            timer1.Start();
            timer1.Tick += UpdateScreen;
           
            InitializeComponent();
            StartGame();
            //for (int i = 0; i < 40; i++)
               // cegielki[i] = new Cegielki(20 + (BRICK_WIDTH + 2) * (i % 10), 6 + (BRICk_HEIGHT + 2) * (i / 10));
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

        }

       private void Form1_Load(object sender, EventArgs e) { }
        private void StartGame()
        {

            ball = new Figury(300, 300, 50, 50,true, 2,2);
            paletka = new Figury(480, 600, 20, 100,false,0,0);

          


        }
        

        private void UpdateScreen(object sender, EventArgs e)

        {

            if  (paletka.get_moving() == true)
                paletka.set_pos_x(paletka.get_pos_x() + 5*paletka.get_right());

            ball.set_pos_x(ball.get_pos_x() + ball.get_right());
            ball.set_pos_y(ball.get_pos_y() + ball.get_up());

            wykryj_kolizje();
           /* for (int i = 0; i < 40; i++)
            {
                cegielki[i] = wykryj_kolizje_cegielka(cegielki[i], i);
            }*/
            pictureBox1.Invalidate();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

           
               
                    Brush BrickColour= Brushes.Red;


            
            //Draw bricks
           
             /*   for (int j = 0; j < 40; j++)
                 { if (cegielki[j]!=null)
                     canvas.FillRectangle(BrickColour,
                         new Rectangle((cegielki[i].up_left_x,
                                         cegielki[j].up_left_y,
                                         BRICK_WIDTH, BRICk_HEIGHT)));
                 }*/
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
            paletka.set_moving(false);
            paletka.set_right(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            paletka.set_moving(true);
            if (paletka.get_right() < 0)
                paletka.set_right(paletka.get_right() - 1);
            else
                paletka.set_right(-1);

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            paletka.set_moving(true);
            if (paletka.get_right() > 0)
                paletka.set_right(paletka.get_right() + 1);
            else
                paletka.set_right(1);
        }

        private void wykryj_kolizje()
        {

            Random rnd = new Random();


            if (((ball.get_pos_y() <= paletka.get_pos_y()) && (ball.get_pos_y()+50 >= paletka.get_pos_y())) && ((ball.get_pos_x() >= paletka.get_pos_x()) && (ball.get_pos_x() <= paletka.get_pos_x()+100)))    //kolizja z rakieta
            {
               
                ball.set_up(-((int)rnd.Next(2, 8)));
                paletka.set_up(paletka.get_up() + 1);
                label2.Text = paletka.get_up().ToString();
                
            }
            if (ball.get_pos_x() <= pictureBox1.Left)
            {
                ball.set_right(((int) rnd.Next(1, 8)));
            }

            if (ball.get_pos_x()+50 >= pictureBox1.Right)
            {
                ball.set_right(-((int)rnd.Next(1, 8)));
            }
            if (ball.get_pos_y() <= pictureBox1.Top)
            {; 
                ball.set_up(((int)rnd.Next(2, 8)));
            }
            if (ball.get_pos_y()+50 >= pictureBox1.Bottom)
            {
                timer1.Stop();
                label1.Visible = true;

            }

            if ((paletka.get_pos_x() <= pictureBox1.Left) || (paletka.get_pos_x()+100 >= pictureBox1.Right))
                paletka.set_moving(false);

        }

        
    }
}
