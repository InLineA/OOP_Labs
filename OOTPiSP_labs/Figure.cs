using System.Drawing;


namespace OOTPiSP_labs
{
    public abstract class Figure
    {
        protected Point startCoords;
        protected Point endCoords;
        private Pen myPen;
        private Brush myBrush;
        private bool isFill;

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

        public bool IsFill
        {
            get { return isFill; }

            set { isFill = value; }
        }
        public abstract void Paint(Graphics graphics);

    }
}
