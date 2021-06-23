using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOTPiSP_labs
{
    public class EllCreate : MyCreateInstance
    {
        public Figure Create(Color color, float penWidth, Color colorFill)
        {
            return new Ellipse(penWidth, color, colorFill);
        }

        public bool manyAng { get { return false; } }
        public bool manyClick { get { return false; } }
        public string name { get { return "Ellipse"; } }
    }
}
