using System;
using System.Drawing;
using System.Windows.Forms;

namespace StopClock
{
    class CloseButton : Button
    {
        Color tmpColor;
        private Color currentColor = Color.DarkGray;
        private Color hoverColor = Color.LightGray;
        private Color clickColor = Color.Black;
        private int textX = 3;
        private int textY = -3;
        private string text = "X";

        public override string Text
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }

        public Color TmpColor
        {
            get { return tmpColor; }
            set { tmpColor = value; Invalidate(); }
        }

        public Color HoverColor
        {
            get { return hoverColor; }
            set { hoverColor = value; Invalidate(); }
        }

        public Color ClickColor
        {
            get { return clickColor; }
            set { clickColor = value; Invalidate(); }
        }

        public int TextLocationX
        {
            get { return textX; }
            set { textX = value; Invalidate(); }
        }

        public int TextLocationY
        {
            get { return textY; }
            set { textY = value; Invalidate(); }
        }

        public CloseButton()
        {
            Size = new Size(31, 24);
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            tmpColor = currentColor;
            currentColor = hoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            currentColor = tmpColor;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            currentColor = clickColor;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            currentColor = tmpColor;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            text = Text;
            if (textX == 100 && textY == 25)
            {
                textX = ((Width / 3) + 10);
                textY = ((Height / 2) - 1);
            }

            Point p = new Point(textX, textY);
            pevent.Graphics.FillRectangle(new SolidBrush(currentColor), ClientRectangle);
            pevent.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), p);
        }
    }
}
