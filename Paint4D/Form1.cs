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
        string shape = "";
        int cursorX = -1;
        int cursorY = -1;
        float penThickness = 4;

        public Form1()
        {
            InitializeComponent();
            graphics = canvas.CreateGraphics();
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            cursorX = e.X;
            cursorY = e.Y;

        }
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape == "rectangle")
            {
                graphics.DrawRectangle(myPen, cursorX, cursorY, e.X - cursorX, e.Y - cursorY);
            }
            else if (shape == "elipse")
            {
                graphics.DrawEllipse(myPen, cursorX, cursorY, e.X - cursorX, e.Y - cursorY);
            }
            else if (shape == "line")
            {
                graphics.DrawLine(myPen, cursorX, cursorY, e.X, e.Y);
            }

            shape = "";
            drawing = false;
            cursorX = 0;
            cursorY = 0;
            
        }
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing == true && shape == "")
            {
                graphics.DrawLine(myPen, new Point(cursorX, cursorY), e.Location);
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
        private void imageBttn_Click(object sender, EventArgs e)
        {
            // hodně jsem konzultoval s googlem a chatGPT sources:
            //https://stackoverflow.com/questions/31984253/adding-graphics-and-image-to-a-picturebox
            //https://stackoverflow.com/questions/10651686/convert-the-image-in-a-picturebox-into-a-bitmap
            //https://learn.microsoft.com/cs-cz/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-8.0
            //https://learn.microsoft.com/en-us/dotnet/api/system.drawing.image.fromfile?view=dotnet-plat-ext-8.0
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;
            Image image1 = Image.FromFile(@filePath);
            graphics.DrawImage(image1, new Point(0, 0));
        }

        //Dál není nic zajímavýho
        //--------------------------------------------------------------------------------------
        private void clear_all_button_Click(object sender, EventArgs e)
        {
            graphics.Clear(canvas.BackColor);
        }
        private void button_white_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.White, penThickness);
        }
        private void button_yellow_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Yellow, penThickness);
        }
        private void button_blue_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Blue, penThickness);
        }
        private void button_green_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Green, penThickness);
        }
        private void button_orange_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Orange, penThickness);
        }
        private void button_red_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Red, penThickness);
        }
        private void button_brown_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Brown, penThickness);
        }
        private void button_black_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Black, penThickness);
        }
        private void EraserButton_Click(object sender, EventArgs e)
        {
            myPen = new Pen(canvas.BackColor, penThickness);
        }
        private void rectangleBttn_Click(object sender, EventArgs e)
        {
            shape = "rectangle";
        }
        private void elipseBttn_Click(object sender, EventArgs e)
        {
            shape = "elipse";
        }
        private void lineBttn_Click(object sender, EventArgs e)
        {
            shape = "line";
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            penThickness = (float)numericUpDown1.Value;
            myPen.Width = (float)numericUpDown1.Value;
        }
    } 
}
