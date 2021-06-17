using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOTPiSP_labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {   
            //Lines
            e.Graphics.DrawLine(Pens.Black, 200, 200, 600, 600);
            e.Graphics.DrawLine(Pens.Black, 20, 20, 20, 60);
            e.Graphics.DrawLine(Pens.Black, 40, 120, 120, 120);

            //Rectangle
            e.Graphics.DrawRectangle(Pens.Blue, new Rectangle(150, 150, 100, 100));

            //Ellipse
            e.Graphics.DrawEllipse(Pens.Purple, new Rectangle(150, 150, 100, 100));
            e.Graphics.DrawEllipse(Pens.Purple, new Rectangle(100, 150, 200, 100));

            //Polygon
            Pen blackPen = new Pen(Color.Black, 3);

            Point point1 = new Point(500, 400);
            Point point2 = new Point(400, 25);
            Point point3 = new Point(1200, 250);
            Point point4 = new Point(1050, 560);
            Point point5 = new Point(1000, 300);

            Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
             };

            e.Graphics.DrawPolygon(blackPen, curvePoints);

            //Polyline
            Point point_1 = new Point(120, 700);
            Point point_2 = new Point(500, 400);
            Point point_3 = new Point(1190, 720);
            Point point_4 = new Point(120, 500);
            Point point_5 = new Point(1000, 300);
            e.Graphics.DrawLine(Pens.Red, point_1, point_2);
            e.Graphics.DrawLine(Pens.Red, point_2, point_3);
            e.Graphics.DrawLine(Pens.Red, point_3, point_4);
            e.Graphics.DrawLine(Pens.Red, point_4, point_5);

        }
    }
}
