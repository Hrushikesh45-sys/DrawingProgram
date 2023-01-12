using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DrawingProgram
{
    public partial class frmMainForm : Form
    {
        private Cursor cursor = new Cursor();
        private Parser parser = new Parser();

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Graphics g = PictureBox.CreateGraphics();

            try
            {
                Command command = parser.Parse(CommandLine.Text);
                switch (command.CmdName)
                {
                    case "rectangle":
                        {
                            Rectangle rect = new Rectangle(cursor.Pos, cursor.Fill, cursor.Color, command.CmdParameters[0], command.CmdParameters[1]);
                            rect.DrawShape(g);
                            break;
                        }
                    case "circle":
                        {
                            Circle circ = new Circle(cursor.Pos, cursor.Fill, cursor.Color, command.CmdParameters[0]);
                            circ.DrawShape(g);
                            break;
                        }
                    case "square":
                        {
                            Square square = new Square(cursor.Pos, cursor.Fill, cursor.Color, command.CmdParameters[0]);
                            square.DrawShape(g);
                            break;
                        }
                    case "triangle":
                        {
                            Triangle tri = new Triangle(cursor.Pos, cursor.Fill, cursor.Color, command.CmdParameters[0]);
                            tri.DrawShape(g);
                            break;
                        }
                    case "drawto":
                        {
                            Line line = new Line(cursor.Pos, cursor.Fill, cursor.Color, new Point(command.CmdParameters[0], command.CmdParameters[1]));
                            line.DrawShape(g);
                            cursor.UpdatePos(line.Pos);
                            cursor.DrawShape(g);
                            break;
                        }
                    case "moveto":
                        {
                            cursor.UpdatePos(new Point(command.CmdParameters[0], command.CmdParameters[1]));
                            cursor.DrawShape(g);
                            break;
                        }
                    case "fillon":
                        {
                            cursor.Fill = true;
                            break;
                        }
                    case "filloff":
                        {
                            cursor.Fill = false;
                            break;
                        }
                    case "reset":
                        {
                            cursor.UpdatePos(new Point(0, 0));
                            cursor.UpdateColor(Color.Black);
                            cursor.UpdateFill(false);
                            cursor.DrawShape(g);
                            break;
                        }
                    case "clear":
                        {
                            g.Clear(SystemColors.Control);
                            cursor.DrawShape(g);
                            break;
                        }
                    case "penred":
                        {
                            cursor.Color = Color.Red;
                            cursor.DrawShape(g);
                            break;
                        }
                    case "pengreen":
                        {
                            cursor.Color = Color.Green;
                            cursor.DrawShape(g);
                            break;
                        }
                    case "penyellow":
                        {
                            cursor.Color = Color.Yellow;
                            cursor.DrawShape(g);
                            break;
                        }
                    case "penblue":
                        {
                            cursor.Color = Color.Blue;
                            cursor.DrawShape(g);
                            break;
                        }
                    case "penpink":
                        {
                            cursor.Color = Color.Pink;
                            cursor.DrawShape(g);
                            break;
                        }
                }
                Errors.Text = "";
                CommandLine.Text = "";
            }
            catch (Exception exception)
            {
                Errors.Text = exception.Message;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            var g = PictureBox.CreateGraphics();
            g.Clear(SystemColors.Control);

            cursor.Pos = new Point(0, 0);
            cursor.Color = Color.Black;
            cursor.Fill = false;
            cursor.DrawShape(g);

            CommandLine.Text = "";
            Errors.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Commands.txt";
            save.Filter = "Text File | *.txt";
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, Multiline.Text);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.Filter = "Text File | *.txt";
            load.RestoreDirectory = true;

            if (load.ShowDialog() == DialogResult.OK)
            {
                Multiline.Text = File.ReadAllText(load.FileName);
            }
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
