using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOTPiSP_labs
{
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
