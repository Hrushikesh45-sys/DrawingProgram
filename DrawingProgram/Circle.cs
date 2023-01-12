using System.Drawing;

namespace DrawingProgram
{
    public class Circle : Shape
    {
        private int Radius { get; set; }

        public Circle(Point pos, bool fill, Color color, int radius) : base(pos, fill, color)
        {
            Radius = radius;
        }

        public override void DrawShape(Graphics g)
        {
            if (Fill == true)
            {
                var brush = new SolidBrush(Color);
                g.FillEllipse(brush, Pos.X - Radius, Pos.Y - Radius, Radius * 2, Radius * 2);
                brush.Dispose();
            }

            else if (Fill == false)
            {
                var pen = new Pen(Color, 2);
                g.DrawEllipse(pen, Pos.X - Radius, Pos.Y - Radius, Radius * 2, Radius * 2);
                pen.Dispose();
            }
        }
    }
}
