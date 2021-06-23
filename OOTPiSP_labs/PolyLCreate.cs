using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOTPiSP_labs
{
    public class PolyLCreate : CreateInstance
    {
        public Figure Create(Color color, float penWidth, Color colorFill)
        {
            return new PolyLine(color, penWidth);
        }
        public bool manyClick { get { return true; } }
    }
}
