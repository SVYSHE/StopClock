using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace StopClock
{
    class RoundButton : Button
    {
        public readonly Stopwatch stopw = new Stopwatch();
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphPath = new GraphicsPath();
            graphPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new Region(graphPath);
            base.OnPaint(pevent);
        }
    }
}
