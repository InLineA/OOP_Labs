using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOTPiSP_labs
{
    public class PolyLine : Figure
    {
        private Point[] points;
        private int pointCounter;

        public PolyLine(Color color, float penWidth) : base(color, penWidth)
        {
            points[0] = new Point(0, 0);
            pointCounter = 1;
        }

        public void AddPoint(Point point)
        {
            points[pointCounter] = new Point(point.X, point.Y);
            pointCounter++;
        }
        public override void Paint(Graphics graphics)
        {
            graphics.DrawLines(this.MyPen, points);
        }

        public override Figure Clone()
        {
            return new PolyLine(MyPen.Color, MyPen.Width);
        }
    }
}
