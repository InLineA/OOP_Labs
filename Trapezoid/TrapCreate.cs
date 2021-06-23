using OOTPiSP_labs;
using System.Drawing;

namespace Trapezoid
{
    public class TrapCreate : MyCreateInstance
    {
        public Figure Create(Color color, float penWidth, Color colorFill)
        {
            return new Trapezoid(color, penWidth, colorFill);
        }
        public bool manyClick { get { return false; } }
        public string name { get { return "Trapezoid"; } }
    }
}
