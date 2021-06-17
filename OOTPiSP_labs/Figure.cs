﻿using System.Drawing;


namespace OOTPiSP_labs
{
    public abstract class Figure
    {
        private Point startCoords;
        private Point endCoords;

        private Pen myPen;

        public Figure(Color color, float penWidth)
        {
            myPen = new Pen(color, penWidth);
        }
        public Point StartCoords
        {
            get
            {
                return startCoords;
            }

            set
            {
                startCoords = value;
            }
        }

        public Point EndCoords
        {
            get
            {
                return endCoords;
            }

            set
            {
                endCoords = value;
            }
        }

        public Pen MyPen
        {
            get
            {
                return myPen;
            }

            set
            {
                myPen = value;
            }
        }

        public abstract void Paint(Graphics graphics);

    }
}
