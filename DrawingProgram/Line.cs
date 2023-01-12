using System.Drawing;

namespace DrawingProgram
{
    public class Line : Shape
    {
        private Point ToPos { get; set; }

        public Line(Point currPos, bool fill, Color color, Point toPos) : base(currPos, fill, color)
        {
            ToPos = toPos;
        }

        public override void DrawShape(Graphics g)
        {
            Pen pen = new Pen(Color, 2);
            g.DrawLine(pen, Pos.X, Pos.Y, ToPos.X, ToPos.Y);
            Pos = ToPos;
            pen.Dispose();
        }
    }
}
