using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace OOTPiSP_labs
{
    [DataContract]
    public class Ellipse : Figure
    {
        [DataMember]
        private int x;
        [DataMember]
        private int y;
        [DataMember]
        private int width;
        [DataMember]
        private int height;

        public Ellipse(float penWidth, Color color, Color fillColor) : base(color, penWidth)
        {
            this.MyBrush = new SolidBrush(fillColor);
        }

        public override void Paint(Graphics graphics)
        {
            x = Math.Min(this.StartCoords.X, this.EndCoords.X);//X should be min of starting and current pos
            y = Math.Min(this.StartCoords.Y, this.EndCoords.Y);//Y should be min of starting and current pos

            width = Math.Abs(this.StartCoords.X - this.EndCoords.X);//width of rect
            height = Math.Abs(this.StartCoords.Y - this.EndCoords.Y);//height of rect

            graphics.FillEllipse(this.MyBrush, x, y, width, height);
            graphics.DrawEllipse(this.MyPen, x, y, width, height);
        }
    }
}
