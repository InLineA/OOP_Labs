﻿

using System.Collections.Generic;
using System.Drawing;

namespace OOTPiSP_labs
{
    public class Polygon : Figure
    {
        private List<Point> points = new List<Point>();

        public Polygon(Color color, float penWidth, Color fillColor):base(color, penWidth)
        {
            this.MyBrush = new SolidBrush(fillColor);
            this.MyPen = new Pen(color, penWidth);
        }

        public override Point StartCoords
        {
            get => base.StartCoords;

            set
            {
                this.startCoords = value;
                points.Add(this.startCoords);

                if (points.Count == 1)
                {
                    points.Add(this.startCoords);
                }
            }
        }

        public override Point EndCoords
        {
            get => base.EndCoords;

            set
            {
                this.endCoords = value;
                points[points.Count - 1] = this.endCoords;
            }
        }

        public override void Paint(Graphics graphics)
        {
            graphics.FillPolygon(this.MyBrush, points.ToArray());
            graphics.DrawPolygon(this.MyPen, points.ToArray());
        }
    }
}
