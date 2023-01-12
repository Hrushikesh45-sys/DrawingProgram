using DrawingProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using Rectangle = DrawingProgram.Rectangle;

namespace UnitTesting
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Parser_Parse_ValidInput_ReturnsCorrectCommand()
        {
            // Arrange
            Parser parser = new Parser();
            string input = "rectangle 50 30";
            string expectedName = "rectangle";
            int[] expectedParameters = new int[] { 50, 30 };

            // Act
            Command result = parser.Parse(input);

            // Assert
            Assert.AreEqual(expectedName, result.CmdName);
            CollectionAssert.AreEqual(expectedParameters, result.CmdParameters);
        }

        [TestMethod]
        public void Shape_DrawShape_ValidGraphics_ShapeIsDrawn()
        {
            // Arrange
            Shape shape = new Rectangle(new Point(0, 0), true, Color.Red, 120, 90);
            Bitmap bitmap = new Bitmap(200, 200);
            Graphics g = Graphics.FromImage(bitmap);

            // Act
            shape.DrawShape(g);

            // Assert
            // Draw a red rectangle on the bitmap and then compare it to the bitmap
            bool isDrawn = false;
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    if (bitmap.GetPixel(x, y) != Color.Transparent)
                    {
                        isDrawn = true;
                        break;
                    }
                }
            }
            Assert.IsTrue(isDrawn);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Parser_Parse_InvalidInput_ThrowsArgumentException()
        {
            // Arrange
            Parser parser = new Parser();
            string input = "cir";

            // Act
            Command result = parser.Parse(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Parser_Parse_EmptyInput_ThrowsArgumentException()
        {
            // Arrange
            Parser parser = new Parser();
            string input = "";

            // Act
            Command result = parser.Parse(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Parser_Parse_TooLongInput_ThrowsArgumentException()
        {
            // Arrange
            Parser parser = new Parser();
            string input = "rectangle 100 200 300 400";

            // Act
            Command result = parser.Parse(input);
        }
    }
}
