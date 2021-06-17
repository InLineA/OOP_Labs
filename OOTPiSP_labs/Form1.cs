using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOTPiSP_labs
{
    public partial class Form1 : Form
    {
        Rectangle Rect;//instance of rectangle

        Point LocationXY;//starting point
        Point LocationX1Y1;//ending point

        bool IsMouseDown = false;//true due to mouse down event
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {


                IsMouseDown = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
