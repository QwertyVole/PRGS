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
        Pen myPen;
        bool drawing = false;
        int cursorX = -1;
        int cursorY = -1;
        public Form1()
        {
            InitializeComponent();
            graphics = canvas.CreateGraphics();
            myPen = new Pen(Color.Black, 2); 

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            cursorX = e.X;
            cursorY = e.Y;

        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if( drawing == true)
            {
                graphics.DrawLine(myPen, new Point(cursorX,cursorY), e.Location) ;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = true;
            cursorX = -1;
            cursorY = -1;
        }
    }
}
