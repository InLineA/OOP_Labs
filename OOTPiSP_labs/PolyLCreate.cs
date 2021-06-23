using System.Drawing;
using System.Runtime.Serialization;


namespace OOTPiSP_labs
{
    [DataContract]
    public class PolyLCreate : CreateInstance
    {
        public Figure Create(Color color, float penWidth, Color colorFill)
        {
            return new PolyLine(color, penWidth);
        }
        public bool manyClick { get { return true; } }
    }
}
