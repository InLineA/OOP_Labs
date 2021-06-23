
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddPlugin = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.AddPlugin);
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
            this.panel1.Location = new System.Drawing.Point(19, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 898);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 851);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddPlugin
            // 
            this.AddPlugin.Location = new System.Drawing.Point(59, 760);
            this.AddPlugin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddPlugin.Name = "AddPlugin";
            this.AddPlugin.Size = new System.Drawing.Size(149, 83);
            this.AddPlugin.TabIndex = 15;
            this.AddPlugin.Text = "AddPlugin";
            this.AddPlugin.UseVisualStyleBackColor = true;
            this.AddPlugin.Click += new System.EventHandler(this.AddPlugin_Click);
            // 
            // Deserealize
            // 
            this.Deserealize.Location = new System.Drawing.Point(59, 667);
            this.Deserealize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Deserealize.Name = "Deserealize";
            this.Deserealize.Size = new System.Drawing.Size(149, 83);
            this.Deserealize.TabIndex = 15;
            this.Deserealize.Text = "Deserealize";
            this.Deserealize.UseVisualStyleBackColor = true;
            this.Deserealize.Click += new System.EventHandler(this.Deserealize_Click);
            // 
            // SerealizeBtn
            // 
            this.SerealizeBtn.Location = new System.Drawing.Point(56, 573);
            this.SerealizeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SerealizeBtn.Name = "SerealizeBtn";
            this.SerealizeBtn.Size = new System.Drawing.Size(149, 83);
            this.SerealizeBtn.TabIndex = 14;
            this.SerealizeBtn.Text = "Serealize";
            this.SerealizeBtn.UseVisualStyleBackColor = true;
            this.SerealizeBtn.Click += new System.EventHandler(this.SerealizeBtn_Click);
            // 
            // RedoBtn
            // 
            this.RedoBtn.Location = new System.Drawing.Point(133, 480);
            this.RedoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RedoBtn.Name = "RedoBtn";
            this.RedoBtn.Size = new System.Drawing.Size(71, 83);
            this.RedoBtn.TabIndex = 13;
            this.RedoBtn.Text = "Redo";
            this.RedoBtn.UseVisualStyleBackColor = true;
            this.RedoBtn.Click += new System.EventHandler(this.RedoBtn_Click);
            // 
            // UndoBtn
            // 
            this.UndoBtn.Location = new System.Drawing.Point(56, 480);
            this.UndoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(71, 83);
            this.UndoBtn.TabIndex = 12;
            this.UndoBtn.Text = "Undo";
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(94, 408);
            this.WidthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(60, 25);
            this.WidthLbl.TabIndex = 11;
            this.WidthLbl.Text = "Width";
            // 
            // WidthBar
            // 
            this.WidthBar.LargeChange = 4;
            this.WidthBar.Location = new System.Drawing.Point(56, 358);
            this.WidthBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WidthBar.Maximum = 4;
            this.WidthBar.Name = "WidthBar";
            this.WidthBar.Size = new System.Drawing.Size(149, 69);
            this.WidthBar.TabIndex = 10;
            this.WidthBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Color2Btn
            // 
            this.Color2Btn.Location = new System.Drawing.Point(136, 223);
            this.Color2Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Color2Btn.Name = "Color2Btn";
            this.Color2Btn.Size = new System.Drawing.Size(71, 83);
            this.Color2Btn.TabIndex = 8;
            this.Color2Btn.Text = "Color 2";
            this.Color2Btn.UseVisualStyleBackColor = true;
            this.Color2Btn.Click += new System.EventHandler(this.Color2Btn_Click);
            // 
            // Color1Btn
            // 
            this.Color1Btn.Location = new System.Drawing.Point(56, 223);
            this.Color1Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Color1Btn.Name = "Color1Btn";
            this.Color1Btn.Size = new System.Drawing.Size(71, 83);
            this.Color1Btn.TabIndex = 7;
            this.Color1Btn.Text = "Color 1";
            this.Color1Btn.UseVisualStyleBackColor = true;
            this.Color1Btn.Click += new System.EventHandler(this.Color1Btn_Click);
            // 
            // PolygonButton
            // 
            this.PolygonButton.Location = new System.Drawing.Point(136, 110);
            this.PolygonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.Size = new System.Drawing.Size(71, 83);
            this.PolygonButton.TabIndex = 5;
            this.PolygonButton.Text = "Polygon";
            this.PolygonButton.UseVisualStyleBackColor = true;
            this.PolygonButton.Click += new System.EventHandler(this.PolygonButton_Click);
            // 
            // EllipseButton
            // 
            this.EllipseButton.Location = new System.Drawing.Point(56, 110);
            this.EllipseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(71, 83);
            this.EllipseButton.TabIndex = 4;
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(174, 17);
            this.RectangleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(71, 83);
            this.RectangleButton.TabIndex = 3;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // PolyLineButton
            // 
            this.PolyLineButton.Location = new System.Drawing.Point(94, 17);
            this.PolyLineButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PolyLineButton.Name = "PolyLineButton";
            this.PolyLineButton.Size = new System.Drawing.Size(71, 83);
            this.PolyLineButton.TabIndex = 2;
            this.PolyLineButton.Text = "Poly line";
            this.PolyLineButton.UseVisualStyleBackColor = true;
            this.PolyLineButton.Click += new System.EventHandler(this.PolyLineButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(14, 17);
            this.LineButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(71, 83);
            this.LineButton.TabIndex = 1;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 1050);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddPlugin;
    }
}


