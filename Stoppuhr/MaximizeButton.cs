using System;
using System.Drawing;
using System.Windows.Forms;

namespace Stoppuhr
{
    class MaximizeButton : Button
    {
        Color tmpColor;
        private Color currentColor = Color.DarkGray;
        private Color hoverColor = Color.LightGray;
        private Color clickColor = Color.Black;
        private int textX = 3;
        private int textY = -8;
        private string text = "_";

        public enum CustomFormState
        {
            Normal,
            Maximized
        }

        CustomFormState customFormState;

        public CustomFormState formState
        {
            get { return customFormState; }
            set { customFormState = value; Invalidate(); }
        }

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

        public MaximizeButton()
        {
            Size = new Size(31, 24);
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Flat;
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

            switch (customFormState)
            {
                case CustomFormState.Normal:
                    pevent.Graphics.FillRectangle(new SolidBrush(currentColor), ClientRectangle);

                    // draw and fill the rectangles of the maximized window
                    for (int i = 0; i < 2; i++)
                    {
                        pevent.Graphics.DrawRectangle(new Pen(ForeColor), textX + i + 1, textY, 10, 10);
                        pevent.Graphics.FillRectangle(new SolidBrush(ForeColor), textX + 1, textY - 1, 12, 4);
                    }
                    break;
                case CustomFormState.Maximized:
                    pevent.Graphics.FillRectangle(new SolidBrush(currentColor), ClientRectangle);

                    // draw and fill the rectangles of the maximized window
                    for (int i = 0; i < 2; i++)
                    {
                        pevent.Graphics.DrawRectangle(new Pen(this.ForeColor), textX + 5, textY, 8, 8);
                        pevent.Graphics.FillRectangle(new SolidBrush(this.ForeColor), textX + 5, textY - 1, 9, 4);

                        pevent.Graphics.DrawRectangle(new Pen(this.ForeColor), textX + 2, textY + 5, 8, 8);
                        pevent.Graphics.FillRectangle(new SolidBrush(this.ForeColor), textX + 2, textY + 4, 9, 4);
                    }
                    break;
            }
        }
    }
}
