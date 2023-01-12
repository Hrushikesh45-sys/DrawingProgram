using System.Drawing;

namespace DrawingProgram
{
    public class Triangle : Shape
    {
        public int Length { get; set; }

        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Triangle(Point pos, bool fill, Color color, int lengthValue) : base(pos, fill, color)
        {
            Length = lengthValue;
            CalculateTrianglePoints(Length);
        }

        public void CalculateTrianglePoints(int length)
        {
            A = new Point(Pos.X, Pos.Y);
            B = new Point(Pos.X, Pos.Y + length);
            C = new Point(Pos.X + length, Pos.Y + length);
        }

        public override void DrawShape(Graphics g)
        {
            Point[] vertices = { A, B, C };

            if (Fill == true)
            {
                var brush = new SolidBrush(Color);
                g.FillPolygon(brush, vertices);
                brush.Dispose();
            }

            else if (Fill == false)
            {
                var pen = new Pen(Color, 2);
                g.DrawPolygon(pen, vertices);
                pen.Dispose();
            }
        }
    }
}