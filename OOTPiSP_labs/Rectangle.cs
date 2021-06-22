using System;
using System.Drawing;


namespace OOTPiSP_labs
{
    public class Rectangle : Figure
    {
        private int x;
        private int y;
        private int width;
        private int height;

        public Rectangle(Color color, float penWidth, bool isFill, Brush brush) : base(color, penWidth)
        {
            this.IsFill = isFill;
            this.MyBrush = brush;
        }

        override public void Paint(Graphics graphics)
        {
            x = Math.Min(this.StartCoords.X, this.EndCoords.X);//X should be min of starting and current pos
            y = Math.Min(this.StartCoords.Y, this.EndCoords.Y);//Y should be min of starting and current pos

            width = Math.Abs(this.StartCoords.X - this.EndCoords.X);//width of rect
            height = Math.Abs(this.StartCoords.Y - this.EndCoords.Y);//height of rect

            if (this.IsFill)
            {
                graphics.FillRectangle(this.MyBrush, x, y, width, height);
            }
            graphics.DrawRectangle(this.MyPen, x, y, width, height);
        }

        public override Figure Clone()
        {
            return new Rectangle(MyPen.Color, MyPen.Width, this.IsFill, this.MyBrush);
        }
    }
}
