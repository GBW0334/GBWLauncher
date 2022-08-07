using System.Drawing;
using System.Windows.Forms;

namespace GBWLauncher
{
    public class TransparentPanelPlayer : Panel
    {
        private string MainText;
        private string Money;
        private string Level;
        private string XP;
        private string Karma;

        public TransparentPanelPlayer(string mainText, string money, string level, string xP, string karma)
        {
            MainText = mainText;
            Money = money;
            Level = level;
            XP = xP;
            Karma = karma;

            Label l = new Label();
            l.FlatStyle = FlatStyle.Flat;
            l.AutoSize = false;
            l.BackColor = Color.Transparent;
            l.ForeColor = Color.White;
            l.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //l.Location = new System.Drawing.Point(0, 9);
            l.Name = "label1";
            l.Left = 2;
            l.Width = this.Width - 2;
            // l.Size = new System.Drawing.Size(155, 32);
            l.TabIndex = 1;
            l.Text = MainText;
            l.Padding = new Padding(0, 5, 0, 10);
            l.Dock = DockStyle.Top;
            l.Height = l.PreferredHeight;
            l.TextAlign = ContentAlignment.MiddleCenter;

            Label d = new Label();
            d.FlatStyle = FlatStyle.Flat;
            d.AutoSize = false;
            d.BackColor = Color.Transparent;
            d.ForeColor = Color.White;
            d.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //l.Location = new System.Drawing.Point(0, 9);
            d.Name = "label2";
            d.Left = 2;
            d.Width = this.Width - 2;
            // l.Size = new System.Drawing.Size(155, 32);
            d.TabIndex = 3;
            d.Text = Money;
            d.Padding = new Padding(5, 5, 0, 0);
            d.Dock = DockStyle.Top;
            d.Height = d.PreferredHeight;
            d.TextAlign = ContentAlignment.MiddleLeft;

            Label ed = new Label();
            ed.FlatStyle = FlatStyle.Flat;
            ed.AutoSize = false;
            ed.BackColor = Color.Transparent;
            ed.ForeColor = Color.White;
            ed.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //l.Location = new System.Drawing.Point(0, 9);
            ed.Name = "label3";
            ed.Left = 2;
            ed.Width = this.Width - 2;
            // l.Size = new System.Drawing.Size(155, 32);
            ed.TabIndex = 4;
            ed.Text = Level;
            ed.Padding = new Padding(5, 5, 0, 0);
            ed.Dock = DockStyle.Top;
            ed.Height = ed.PreferredHeight;
            ed.TextAlign = ContentAlignment.MiddleLeft;

            Label g = new Label();
            g.FlatStyle = FlatStyle.Flat;
            g.AutoSize = false;
            g.BackColor = Color.Transparent;
            g.ForeColor = Color.White;
            g.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //l.Location = new System.Drawing.Point(0, 9);
            g.Name = "label4";
            g.Left = 2;
            g.Width = this.Width - 2;
            // l.Size = new System.Drawing.Size(155, 32);
            g.TabIndex = 5;
            g.Text = XP;
            g.Padding = new Padding(5, 5, 0, 0);
            g.Dock = DockStyle.Top;
            g.Height = g.PreferredHeight;
            g.TextAlign = ContentAlignment.MiddleLeft;

            Label t = new Label();
            t.FlatStyle = FlatStyle.Flat;
            t.AutoSize = false;
            t.BackColor = Color.Transparent;
            t.ForeColor = Color.White;
            t.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //l.Location = new System.Drawing.Point(0, 9);
            t.Name = "label5";
            t.Left = 2;
            t.Width = this.Width - 2;
            // l.Size = new System.Drawing.Size(155, 32);
            t.TabIndex = 6;
            t.Text = Karma;
            t.Padding = new Padding(5, 5, 0, 0);
            t.Dock = DockStyle.Top;
            t.Height = t.PreferredHeight;
            t.TextAlign = ContentAlignment.MiddleLeft;
            Controls.Add(t);
            Controls.Add(ed);
            Controls.Add(g);
            Controls.Add(d);
            Controls.Add(l);
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
            Show();
            //base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }
    }
}
