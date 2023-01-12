using System.Drawing;

namespace DrawingProgram
{
    public class Cursor : Shape
    {
        public Cursor() : base(new Point(0, 0), false, Color.Black)
        {

        }

        public void UpdatePos(Point pos)
        {
            Pos = pos;
        }

        public void UpdateColor(Color penColor)
        {
            Color = penColor;
        }

        public void UpdateFill(bool fillState)
        {
            Fill = fillState;
        }

        public override void DrawShape(Graphics g)
        {
            var b = new SolidBrush(Color);
            g.FillRectangle(b, Pos.X, Pos.Y, 5, 5);
        }
    }
}
