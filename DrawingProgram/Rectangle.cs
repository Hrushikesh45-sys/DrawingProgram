using System.Drawing;

namespace DrawingProgram
{
    public class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public Rectangle(Point pos, bool fill, Color color, int len, int height) : base(pos, fill, color)
        {
            Length = len;
            Height = height;
        }

        public override void DrawShape(Graphics g)
        {
            if (Fill == true)
            {
                Brush brush = new SolidBrush(Color);
                g.FillRectangle(brush, Pos.X, Pos.Y, Length, Height);
                brush.Dispose();
            }

            else if (Fill == false)
            {
                Pen pen = new Pen(Color, 2);
                g.DrawRectangle(pen, Pos.X, Pos.Y, Length, Height);
                pen.Dispose();
            }
        }
    }
}
