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
<<<<<<< HEAD
        private Color color;
        [DataMember]
        private float penWidth;
=======
        private Pen myPen;
>>>>>>> 99eeaec9bb2e5f9015b19f123914b6865aa32e2d
        [DataMember]
        private Brush myBrush;

        public Figure(Color color, float penWidth)
        {
            this.color = color;
            this.penWidth = penWidth;
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
            get{return new Pen(color, penWidth);}

            set{color = value.Color; penWidth = value.Width; }
        }

        public Brush MyBrush
        {
            get { return myBrush; }

            set { myBrush = value; }
        }
        public abstract void Paint(Graphics graphics);

    }
}
