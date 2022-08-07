using System.Drawing;
using System.Windows.Forms;

namespace GBWLauncher
{
    public class TransparentPanel : Panel
    {
        private string v;

        public TransparentPanel(string v)
        {
            this.v = v;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Label l = new Label();
            l.FlatStyle = FlatStyle.Flat;
            l.AutoSize = false;
            l.BackColor = Color.Transparent;
            l.ForeColor = Color.White;
            l.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //l.Location = new System.Drawing.Point(0, 9);
            l.Name = "label1";
            l.Left = 2;
            l.Width = this.Width - 2;
           // l.Size = new System.Drawing.Size(155, 32);
            l.TabIndex = 2;
            l.Text = v;
            l.Padding = new Padding(0,5,0,0);
            l.Dock = DockStyle.None;
            l.Height = l.PreferredHeight;
            l.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(l);
            Show();
            //base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }
    }
}
