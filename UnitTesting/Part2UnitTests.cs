using DrawingProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace UnitTesting
{
    [TestClass]
    public class Part2UnitTests
    {
        [Ignore]
        [TestMethod]
        public void Part2_Factory()
        {
            // Arrange
            Factory factory = new Factory();
            Command command = new Command("rectangle", new int[] { 100, 100 });

            // Act
            Shape result = factory.CreateShape(command, new Point(50, 50), true, Color.Red);

            // Assert
            Assert.IsInstanceOfType(result, typeof(DrawingProgram.Rectangle));
        }

        [Ignore]
        [TestMethod]
        public void Part2_Variables()
        {
            // Arrange
            Parser parser = new Parser();
            string input = "var x = 250";

            // Act
            Command command = parser.Parse(input);
        }

        [Ignore]
        [TestMethod]
        public void Part2_IfStatements()
        {
            // Arrange
            Parser parser = new Parser();
            string input = "if x > 200\ncircle x";

            // Act
            Command command = parser.Parse(input);
        }
    }

    // Factory class sample for part 2 implementation
    internal class Factory
    {
        internal Shape CreateShape(Command command, Point point, bool v, Color red)
        {
            throw new NotImplementedException();
        }
    }
}
