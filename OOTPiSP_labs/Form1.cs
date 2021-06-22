using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOTPiSP_labs
{
    public partial class Form1 : Form
    {
        private bool isFill = false;
        private Pen pen = new Pen(Color.Black, 1);
        private Brush brush = new SolidBrush(Color.White);
        private Figure figure = new Line(Color.Black, 1);
        private Storage storage = new Storage();
        private bool isMouseDown = false;//true due to mouse down event
        private bool isSpace = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (figure != null)
                {
                    figure = figure.Clone();

                    isMouseDown = true;

                    figure.StartCoords = e.Location;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                figure.EndCoords = e.Location;

                Refresh();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isMouseDown)
                {
                    if (figure != null)
                    {
                        storage.AddToStorage(figure);
                    }

                    figure = figure.Clone();

                    isMouseDown = false;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure fig in storage.GetList())
            {
                fig.Paint(e.Graphics);
            }
            if ((isMouseDown) && (figure != null))
            {
                figure.Paint(e.Graphics);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = WidthBar.Value + 1;

            figure.MyPen.Width = WidthBar.Value + 1;//overwriting the width

            //TODO Change field with pen width
            figure = figure.Clone();
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            figure = new Line(pen.Color, pen.Width);
        }

        private void PolyLineButton_Click(object sender, EventArgs e)
        {
            figure = new PolyLine(pen.Color, pen.Width);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            figure = new Rectangle(pen.Color, pen.Width, isFill, brush);
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            figure = new Ellipse(pen.Color, pen.Width, isFill, brush);
        }

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            figure = new Polygon(pen.Color, pen.Width, isFill, brush);
        }

        private void IsFillBtn_CheckedChanged(object sender, EventArgs e)
        {
            isFill = IsFillBtn.Checked;

            figure.IsFill = IsFillBtn.Checked;

            //TODO Change field isFilled
        }

        private void Color1Btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                Color1Btn.BackColor = colorDialog1.Color;

                figure.MyPen.Color = colorDialog1.Color;

                //TODO Change field with pen color
            }
        }

        private void Color2Btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brush = new SolidBrush(colorDialog1.Color);
                Color2Btn.BackColor = colorDialog1.Color;

                figure.MyBrush = new SolidBrush(colorDialog1.Color);

                //TODO Change field with brush color
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Space)
            {

            }
        }
    }
}
