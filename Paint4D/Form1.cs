using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint4D
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen myPen = new Pen(Color.Black, 2);
        bool drawing = false;
        int cursorX = -1;
        int cursorY = -1;
        
        public Form1()
        {
            InitializeComponent();
            graphics = canvas.CreateGraphics();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            cursorX = e.X;
            cursorY = e.Y;

        }
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            cursorX = 0;
            cursorY = 0;
        }
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if( drawing == true)
            {
                graphics.DrawLine(myPen, new Point(cursorX,cursorY), e.Location) ;
                cursorX = e.X;
                cursorY = e.Y;
            }
        }

        private void new_canvas_button_Click(object sender, EventArgs e)
        {
            //if you close the first instance, you close all instances
            Form1 NewForm = new Form1();
            NewForm.Show();
        }

        private void clear_all_button_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }
        private void button_white_Click(object sender, EventArgs e)
        {
            myPen =  new Pen(Color.White, 2);
        }
        private void button_yellow_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Yellow, 2);
        }
        private void button_blue_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Blue, 2);
        }
        private void button_green_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Green, 2);
        }
        private void button_orange_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Orange, 2);
        }
        private void button_red_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Red, 2);
        }
        private void button_brown_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Brown, 2);
        }
        private void button_black_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Black, 2);
        }
    }
}
