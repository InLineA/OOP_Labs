
namespace OOTPiSP_labs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deserealize = new System.Windows.Forms.Button();
            this.SerealizeBtn = new System.Windows.Forms.Button();
            this.RedoBtn = new System.Windows.Forms.Button();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.WidthBar = new System.Windows.Forms.TrackBar();
            this.Color2Btn = new System.Windows.Forms.Button();
            this.Color1Btn = new System.Windows.Forms.Button();
            this.PolygonButton = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.PolyLineButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.Deserealize);
            this.panel1.Controls.Add(this.SerealizeBtn);
            this.panel1.Controls.Add(this.RedoBtn);
            this.panel1.Controls.Add(this.UndoBtn);
            this.panel1.Controls.Add(this.WidthLbl);
            this.panel1.Controls.Add(this.WidthBar);
            this.panel1.Controls.Add(this.Color2Btn);
            this.panel1.Controls.Add(this.Color1Btn);
            this.panel1.Controls.Add(this.PolygonButton);
            this.panel1.Controls.Add(this.EllipseButton);
            this.panel1.Controls.Add(this.RectangleButton);
            this.panel1.Controls.Add(this.PolyLineButton);
            this.panel1.Controls.Add(this.LineButton);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 460);
            this.panel1.TabIndex = 0;
            // 
            // Deserealize
            // 
            this.Deserealize.Location = new System.Drawing.Point(41, 400);
            this.Deserealize.Name = "Deserealize";
            this.Deserealize.Size = new System.Drawing.Size(104, 50);
            this.Deserealize.TabIndex = 15;
            this.Deserealize.Text = "Deserealize";
            this.Deserealize.UseVisualStyleBackColor = true;
            // 
            // SerealizeBtn
            // 
            this.SerealizeBtn.Location = new System.Drawing.Point(39, 344);
            this.SerealizeBtn.Name = "SerealizeBtn";
            this.SerealizeBtn.Size = new System.Drawing.Size(104, 50);
            this.SerealizeBtn.TabIndex = 14;
            this.SerealizeBtn.Text = "Serealize";
            this.SerealizeBtn.UseVisualStyleBackColor = true;
            this.SerealizeBtn.Click += new System.EventHandler(this.SerealizeBtn_Click);
            // 
            // RedoBtn
            // 
            this.RedoBtn.Location = new System.Drawing.Point(93, 288);
            this.RedoBtn.Name = "RedoBtn";
            this.RedoBtn.Size = new System.Drawing.Size(50, 50);
            this.RedoBtn.TabIndex = 13;
            this.RedoBtn.Text = "Redo";
            this.RedoBtn.UseVisualStyleBackColor = true;
            this.RedoBtn.Click += new System.EventHandler(this.RedoBtn_Click);
            // 
            // UndoBtn
            // 
            this.UndoBtn.Location = new System.Drawing.Point(39, 288);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(50, 50);
            this.UndoBtn.TabIndex = 12;
            this.UndoBtn.Text = "Undo";
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(66, 245);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(39, 15);
            this.WidthLbl.TabIndex = 11;
            this.WidthLbl.Text = "Width";
            // 
            // WidthBar
            // 
            this.WidthBar.LargeChange = 4;
            this.WidthBar.Location = new System.Drawing.Point(39, 215);
            this.WidthBar.Maximum = 4;
            this.WidthBar.Name = "WidthBar";
            this.WidthBar.Size = new System.Drawing.Size(104, 45);
            this.WidthBar.TabIndex = 10;
            this.WidthBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Color2Btn
            // 
            this.Color2Btn.Location = new System.Drawing.Point(95, 134);
            this.Color2Btn.Name = "Color2Btn";
            this.Color2Btn.Size = new System.Drawing.Size(50, 50);
            this.Color2Btn.TabIndex = 8;
            this.Color2Btn.Text = "Color 2";
            this.Color2Btn.UseVisualStyleBackColor = true;
            this.Color2Btn.Click += new System.EventHandler(this.Color2Btn_Click);
            // 
            // Color1Btn
            // 
            this.Color1Btn.Location = new System.Drawing.Point(39, 134);
            this.Color1Btn.Name = "Color1Btn";
            this.Color1Btn.Size = new System.Drawing.Size(50, 50);
            this.Color1Btn.TabIndex = 7;
            this.Color1Btn.Text = "Color 1";
            this.Color1Btn.UseVisualStyleBackColor = true;
            this.Color1Btn.Click += new System.EventHandler(this.Color1Btn_Click);
            // 
            // PolygonButton
            // 
            this.PolygonButton.Location = new System.Drawing.Point(95, 66);
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.Size = new System.Drawing.Size(50, 50);
            this.PolygonButton.TabIndex = 5;
            this.PolygonButton.Text = "Polygon";
            this.PolygonButton.UseVisualStyleBackColor = true;
            this.PolygonButton.Click += new System.EventHandler(this.PolygonButton_Click);
            // 
            // EllipseButton
            // 
            this.EllipseButton.Location = new System.Drawing.Point(39, 66);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(50, 50);
            this.EllipseButton.TabIndex = 4;
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(122, 10);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(50, 50);
            this.RectangleButton.TabIndex = 3;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // PolyLineButton
            // 
            this.PolyLineButton.Location = new System.Drawing.Point(66, 10);
            this.PolyLineButton.Name = "PolyLineButton";
            this.PolyLineButton.Size = new System.Drawing.Size(50, 50);
            this.PolyLineButton.TabIndex = 2;
            this.PolyLineButton.Text = "Poly line";
            this.PolyLineButton.UseVisualStyleBackColor = true;
            this.PolyLineButton.Click += new System.EventHandler(this.PolyLineButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(10, 10);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(50, 50);
            this.LineButton.TabIndex = 1;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 630);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Color2Btn;
        private System.Windows.Forms.Button Color1Btn;
        private System.Windows.Forms.Button PolygonButton;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button PolyLineButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.TrackBar WidthBar;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.Button Deserealize;
        private System.Windows.Forms.Button SerealizeBtn;
        private System.Windows.Forms.Button RedoBtn;
        private System.Windows.Forms.Button UndoBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


