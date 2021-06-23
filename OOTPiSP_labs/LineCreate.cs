using System.Drawing;

namespace OOTPiSP_labs
{
    public class LineCreate : CreateInstance
    {
        public Figure Create(Color color, float penWidth, Color colorFill)
        {
            return new Line(color, penWidth);
        }
        public bool manyClick { get { return false; } }
    }
}
