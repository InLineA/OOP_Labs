using System.Drawing;
using System.Runtime.Serialization;

namespace OOTPiSP_labs
{
    [DataContract]
    public abstract class Figure
    {
        [DataMember]
        protected Point startCoords;
        [DataMember]
        protected Point endCoords;
        [DataMember]
        private Pen myPen;
        [DataMember]
        private Brush myBrush;

        public Figure(Color color, float penWidth)
        {
            myPen = new Pen(color, penWidth);
        }
        public virtual Point StartCoords
        {
            get{return startCoords;}

            set{startCoords = value;}
        }

        public virtual Point EndCoords
        {
            get{return endCoords;}

            set{endCoords = value;}
        }

        public Pen MyPen
        {
            get{return myPen;}

            set{myPen = value;}
        }

        public Brush MyBrush
        {
            get { return myBrush; }

            set { myBrush = value; }
        }
        public abstract void Paint(Graphics graphics);

    }
}
