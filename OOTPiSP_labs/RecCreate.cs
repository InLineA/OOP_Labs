using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOTPiSP_labs
{
    public class RecCreate : CreateInstance
    {
        public Figure Create(Color color, float penWidth, Color colorFill)
        {
            return new Rectangle(color, penWidth, colorFill);
        }
        public bool manyClick { get { return false; } }
    }
}
