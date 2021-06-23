using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.Json;

namespace OOTPiSP_labs
{
    public partial class Form1 : Form
    {
        private Point start;
        private Point end;
        private Color fillColor;
        private Pen pen = new Pen(Color.Black, 1);
        private Brush brush = new SolidBrush(Color.White);
        private Figure figure;
        private CreateInstance create = new LineCreate();
        private Storage storage = new Storage();
        private bool isMouseDown = false;//true due to mouse down event
        private bool isSpace = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (create != null)
            {
                if (!isMouseDown && !create.manyClick)
                {
                    figure = create.Create(pen.Color, pen.Width, fillColor);

                    isMouseDown = !isMouseDown;
                    start.X = e.X;
                    start.Y = e.Y;

                    figure.StartCoords = start;
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (create != null)
            {
                if (create.manyClick)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        start.X = e.X;
                        start.Y = e.Y;

                        if (!isMouseDown)
                        {
                            figure = create.Create(pen.Color, pen.Width, fillColor);
                            figure.StartCoords = start;

                            isMouseDown = !isMouseDown;
                        }
                        else
                        {
                            figure.StartCoords = start;
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        isMouseDown = !isMouseDown;
                        storage.AddToStorage(figure);
                        storage.ResetStack();
                    }
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        { 
            if (isMouseDown)
                {
                    end.X = e.X;
                    end.Y = e.Y;

                    figure.EndCoords = end;
                    Refresh();
                }
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown && !create.manyClick)
            {
                end.X = e.X;
                end.Y = e.Y;
                isMouseDown = !isMouseDown;
                if (start != end)
                {
                    figure.EndCoords = end;
                    storage.AddToStorage(figure);
                    storage.ResetStack();
                }
                figure = create.Create(pen.Color, pen.Width, fillColor);
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

            figure.MyPen.Width = WidthBar.Value + 1;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            create = new LineCreate();
        }

        private void PolyLineButton_Click(object sender, EventArgs e)
        {
            create = new PolyLCreate();
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            create = new RecCreate();
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            create = new EllCreate();
        }

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            create = new PolygonCreate();
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
                fillColor = colorDialog1.Color;
                Color2Btn.BackColor = colorDialog1.Color;


                //TODO Change field with brush color
            }
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            storage.DeleteFigure();
            Refresh();
        }

        private void RedoBtn_Click(object sender, EventArgs e)

        {
            storage.Redo();
            Refresh();
        }

        private void SerealizeBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}