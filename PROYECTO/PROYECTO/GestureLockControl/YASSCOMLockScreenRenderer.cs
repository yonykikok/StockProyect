using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GestureLockApp.GestureLockControl
{
    public class YASSCOMLockScreenRenderer : LockScreenRenderer, IDisposable
    {
        private readonly Pen padPen, gesturePen;
        private readonly SolidBrush activeBrush = new SolidBrush(Color.Empty);

        public YASSCOMLockScreenRenderer()
        {
            padPen = new Pen(Color.Empty, 5);
            gesturePen = new Pen(Color.Empty, 10);
            gesturePen.StartCap = gesturePen.EndCap = LineCap.Round;
            gesturePen.LineJoin = LineJoin.Round;
            ApplyThemeToUtencils();
        }

        private void ApplyThemeToUtencils()
        {
            Color c = Color.FromArgb(0, 80, 200);
            gesturePen.Color = Color.FromArgb(100, 255, 255, 255);
            padPen.Color = activeBrush.Color = c;
        }

        public override void RenderBackground(Graphics graphics, RectangleF bounds, Color backColor)
        {
            graphics.Clear(Color.FromArgb(22, 32, 40));
        }

        public override void RenderGesture(Graphics graphics, PointF[] polygon)
        {
            graphics.DrawLines(gesturePen, polygon);
        }

        public override void RenderPad(Graphics graphics, RectangleF bounds, GesturePadState state, int index)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawEllipse(padPen, bounds);
            if (state.HasFlag(GesturePadState.Inputted))
            {
                float inflationAmount = bounds.Width * 1.3f;
                var innerRect = bounds;
                innerRect.Inflate(-inflationAmount, -inflationAmount);
                graphics.FillEllipse(activeBrush, innerRect);
            }
        }

        public void Dispose()
        {
            padPen.Dispose();
            gesturePen.Dispose();
            activeBrush.Dispose();
        }
    }
}