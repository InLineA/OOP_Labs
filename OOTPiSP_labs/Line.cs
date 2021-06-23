using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;

namespace OOTPiSP_labs
{
    [DataContract]
    public class Line : Figure
    {


        public Line(Color color, float penWidth) : base(color, penWidth) 
        {

        }

        public override void Paint(Graphics graphics)
        {
            graphics.DrawLine(MyPen, StartCoords, EndCoords);
        }
    }
}
