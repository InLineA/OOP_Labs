using OOTPiSP_labs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;

namespace Trapezoid
{
    [DataContract]
    class Trapezoid : Figure
    {
        [DataMember]
        private Point[] points;

        public Trapezoid(Color color, float penWidth, Color fillColor) : base(color, penWidth)
        {
            this.MyBrush = new SolidBrush(fillColor);
        }

        override public void Paint(Graphics graphics)
        {
            int width = Math.Abs(endCoords.X - startCoords.X) / 3;
            points = new Point[4] { new Point(startCoords.X + width, startCoords.Y), new Point(endCoords.X - width, startCoords.Y), endCoords, new Point(startCoords.X, endCoords.Y) };


            graphics.FillPolygon(this.MyBrush, points);
            graphics.DrawPolygon(this.MyPen, points);
        }
    }
}
