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

        public Rectangle(Color color, float penWidth, Color fillColor) : base(color, penWidth)
        {
            this.MyBrush = new SolidBrush(fillColor);
        }

        override public void Paint(Graphics graphics)
        {
            x = Math.Min(this.StartCoords.X, this.EndCoords.X);//X should be min of starting and current pos
            y = Math.Min(this.StartCoords.Y, this.EndCoords.Y);//Y should be min of starting and current pos

            width = Math.Abs(this.StartCoords.X - this.EndCoords.X);//width of rect
            height = Math.Abs(this.StartCoords.Y - this.EndCoords.Y);//height of rect


            graphics.FillRectangle(this.MyBrush, x, y, width, height);

            graphics.DrawRectangle(this.MyPen, x, y, width, height);
        }
    }
}
