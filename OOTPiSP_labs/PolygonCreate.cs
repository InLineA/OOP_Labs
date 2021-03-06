using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOTPiSP_labs
{
    public class PolygonCreate : MyCreateInstance
    {
        public Figure Create(Color color, float thickness, Color colorFill)
        {
            return new Polygon(color, thickness, colorFill);
        }
        public bool manyClick { get { return true; } }
        public string name { get { return "Polygon"; } }
    }
}
