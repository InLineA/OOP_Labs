using System.Drawing;
using System.Runtime.Serialization;


namespace OOTPiSP_labs
{
    [DataContract]
    public class PolyLCreate : MyCreateInstance
    {
        public Figure Create(Color color, float penWidth, Color colorFill)
        {
            return new PolyLine(color, penWidth);
        }
        public bool manyClick { get { return true; } }
        public string name { get { return "PolyLine"; } }
    }
}
