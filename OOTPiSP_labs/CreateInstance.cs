using System.Drawing;

namespace OOTPiSP_labs
{
    public interface CreateInstance
    {
            bool manyClick { get; }


            Figure Create(Color color, float thickness, Color colorFill);
    }
}
