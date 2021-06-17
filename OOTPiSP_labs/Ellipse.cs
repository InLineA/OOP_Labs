﻿using System;
using System.Drawing;


namespace OOTPiSP_labs
{
    public class Ellipse : Figure
    {
        private int x;
        private int y;
        private int width;
        private int height;

        public Ellipse(Color color, float penWidth) : base(color, penWidth)
        {

        }

        public override void Paint(Graphics graphics)
        {
            x = Math.Min(this.StartCoords.X, this.EndCoords.X);//X should be min of starting and current pos
            y = Math.Min(this.StartCoords.Y, this.EndCoords.Y);//Y should be min of starting and current pos

            width = Math.Abs(this.StartCoords.X - this.EndCoords.X);//width of rect
            height = Math.Abs(this.StartCoords.Y - this.EndCoords.Y);//height of rect

            graphics.DrawEllipse(this.MyPen, x, y, width, height);
        }
    }
}