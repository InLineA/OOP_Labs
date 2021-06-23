using System.Drawing;
using System.Runtime.Serialization;


namespace OOTPiSP_labs
{
    [DataContract]
<<<<<<< HEAD
    public class PolyLCreate : MyCreateInstance
=======
    public class PolyLCreate : CreateInstance
>>>>>>> 99eeaec9bb2e5f9015b19f123914b6865aa32e2d
    {
        public Figure Create(Color color, float penWidth, Color colorFill)
        {
            return new PolyLine(color, penWidth);
        }
        public bool manyClick { get { return true; } }
        public string name { get { return "PolyLine"; } }
    }
}
