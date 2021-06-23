using System.Drawing;

namespace OOTPiSP_labs
{
    public interface MyCreateInstance
    {
        bool manyClick { get; }
        string name { get; }

        Figure Create(Color color, float thickness, Color colorFill);

    }
}
