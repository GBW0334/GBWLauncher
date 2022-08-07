using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace GBWLauncher
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]
    public partial class JustPanelD : UserControl
    {
        private int nRadius = 20;

        // crash on VS 2015

        //[Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        //[Description("Text for User Control"), Category("Data")]
        //public override string Text 
        //{
        //    get { return this.Text; }
        //    set { this.Text = value; }
        //}

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Text for User Control"), Category("Data")]
        public string ControlText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int Radius
        {
            get { return nRadius; }
            set { nRadius = value; }
        }

        private System.Drawing.Color borderColor = System.Drawing.Color.Red;

        public System.Drawing.Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        private System.Drawing.Color fillColor = System.Drawing.SystemColors.ButtonFace;

        public System.Drawing.Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }

        private int nBorderSize = 4;

        public int BorderSize
        {
            get { return nBorderSize; }
            set { nBorderSize = value; }
        }

        public JustPanelD()
        {
            //InitializeComponent();
        }

        public JustPanelD(int nRadius = 20, System.Drawing.Color? fillColor = null, System.Drawing.Color? borderColor = null, int borderSize = 4) : this()
        {
            Radius = nRadius;
            FillColor = fillColor ?? System.Drawing.SystemColors.ButtonFace;
            BorderColor = borderColor ?? System.Drawing.Color.Red;
            BorderSize = borderSize;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            nRadius = Math.Min(nRadius, Height - BorderSize * 2);
            Rectangle rect = new Rectangle(BorderSize, BorderSize, Width - BorderSize * 2, Height - BorderSize * 2);
            using (System.Drawing.Drawing2D.GraphicsPath gp = CreatePath(rect, nRadius, false))
            {
                System.Drawing.Pen pen = new System.Drawing.Pen(BorderColor, BorderSize);
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                e.Graphics.FillPath(new SolidBrush(Color.FromArgb(100, Color.Black)), gp);
                e.Graphics.DrawPath(pen, gp);
            }

            //System.Drawing.Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
            System.Drawing.Size textSize = TextRenderer.MeasureText(this.ControlText, this.Font);
            var nWidth = ((this.Width - textSize.Width) / 2);
            var nHeight = ((this.Height - textSize.Height) / 2);
            System.Drawing.Point drawPoint = new System.Drawing.Point(nWidth, nHeight);
            Rectangle normalRect = new Rectangle(drawPoint, textSize);
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, normalRect, ForeColor);
        }

        public static System.Drawing.Drawing2D.GraphicsPath CreatePath(Rectangle rect, int nRadius, bool bOutline)
        {
            int nShift = bOutline ? 1 : 0;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X + nShift, rect.Y, nRadius, nRadius, 180f, 90f);
            path.AddArc((rect.Right - nRadius) - nShift, rect.Y, nRadius, nRadius, 270f, 90f);
            path.AddArc((rect.Right - nRadius) - nShift, (rect.Bottom - nRadius) - nShift, nRadius, nRadius, 0f, 90f);
            path.AddArc(rect.X + nShift, (rect.Bottom - nRadius) - nShift, nRadius, nRadius, 90f, 90f);
            path.CloseFigure();
            return path;
        }
    }
}
