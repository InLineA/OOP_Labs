

using System.Collections.Generic;
using System.Drawing;

namespace OOTPiSP_labs
{
    public class Polygon : Figure
    {
        private List<Point> points = new List<Point>();
        private int pointCounter = 1;

        public Polygon(Color color, float penWidth, bool isFill, Brush myBrush):base(color, penWidth)
        {
            this.IsFill = isFill;
            this.MyBrush = myBrush;
        }

        public override void Paint(Graphics graphics)
        {
            if (pointCounter == 1)
            {
                points.Add(this.StartCoords);
                points.Add(this.EndCoords);
                pointCounter++;
            }
            else if (pointCounter > 1)
            {
                graphics.DrawLines(this.MyPen, points.ToArray());
            }
        }

        public override Figure Clone()
        {
            return new Polygon(MyPen.Color, MyPen.Width, this.IsFill, this.MyBrush);
        }
    }
}
