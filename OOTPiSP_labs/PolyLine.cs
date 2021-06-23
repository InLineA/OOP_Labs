using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;

namespace OOTPiSP_labs
{
    [DataContract]
    public class PolyLine : Figure
    {
        [DataMember]
        private List<Point> points = new List<Point>();

        public PolyLine(Color color, float penWidth) : base(color, penWidth)
        {
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
            graphics.DrawLines(this.MyPen, points.ToArray());
        }
    }
}
