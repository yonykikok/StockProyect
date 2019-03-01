using System;
using System.Drawing;
namespace GestureLockApp.GestureLockControl
{
    [Flags]
    public enum GesturePadState
    {
        None = 0,
        Hovered = 1,
        Inputted = 2,
        LastInputted = 4,
        FirstInputted = 8
    }

    public abstract class LockScreenRenderer
    {
        public abstract void RenderBackground(Graphics graphics, RectangleF bounds, Color backColor);

        public abstract void RenderGesture(Graphics graphics, PointF[] polygon);

        public abstract void RenderPad(Graphics graphics, RectangleF bounds, GesturePadState state, int index);
    }
}