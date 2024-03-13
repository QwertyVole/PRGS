using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProjektPRGS
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int? firstNum;
        int? secondNum;
        string cache ;
        int operation; 
        
        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            firstNum = null;
            secondNum = null;
            textBox1.Text = null;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (cache.Length > 0)
            {
                cache = cache.Remove(cache.Length - 1);
            }
            textBox1.Text = cache;
        }


        private void Operation_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToInt32(cache);
            cache = "";
            operation = 1 ;
            switch (sender)
            {
                case buttonPlus:
                    operation = 1;
                    break;
                case buttonPlus:
                    operation = 1;
            }
                

        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            cache +='';
            textBox1.Text = cache;
        }
    }
}
