

using System.Drawing;

namespace OOTPiSP_labs
{
    public class Polygon : Figure
    {
        private Point[] points;
        private int pointCounter;
        private Brush myBrush;
        private bool isFilled;

        public Polygon(Color color, float penWidth, bool fill, Brush brush):base(color, penWidth)
        {
            points[0] = this.StartCoords;
            isFilled = fill;
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
    }
}
