using System.Drawing;

namespace DrawingProgram
{
    public abstract class Shape
    {
        public Point Pos { get; set; }
        public bool Fill { get; set; }
        public Color Color { get; set; }

        public Shape(Point pos, bool fill, Color color)
        {
            Pos = pos;
            Fill = fill;
            Color = color;
        }

        public abstract void DrawShape(Graphics g);
    }
}
