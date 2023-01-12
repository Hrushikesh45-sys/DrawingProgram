using System.Drawing;

namespace DrawingProgram
{
    public class Square : Rectangle
    {
        private int Side { get; set; }

        public Square(Point pos, bool fill, Color color, int side) : base(pos, fill, color, side, side)
        {
            Side = side;
        }

        public override void DrawShape(Graphics g)
        {
            if (Fill == true)
            {
                var brush = new SolidBrush(Color);
                g.FillRectangle(brush, Pos.X, Pos.Y, Side, Side);
                brush.Dispose();
            }
            else if (Fill == false)
            {
                var pen = new Pen(Color, 2);
                g.DrawRectangle(pen, Pos.X, Pos.Y, Side, Side);
                pen.Dispose();
            }
        }
    }
}
