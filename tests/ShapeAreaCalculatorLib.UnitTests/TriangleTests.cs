using ShapeAreaCalculatorLib.Shapes;

namespace ShapeAreaCalculatorLib.UnitTests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(40,40,9)]
        [TestCase(5,6,7)]
        [TestCase(1230,321,1230)]
        public void IsValidTriangle_WhenValidSides_ShouldNotThrow(double sideOne, double sideTwo, double sideThree)
        {
            // Arrange & Act & Assert
            Assert.DoesNotThrow(() => new Triangle(sideOne, sideTwo, sideThree));
        }

        [TestCase(400, 40, 9)]
        [TestCase(50, 6, 7)]
        [TestCase(1230, 32100, 1230)]
        [TestCase(0, 0, 0)]
        public void IsValidTriangle_WhenNoValidSides_ShouldArgumentException(double sideOne, double sideTwo, double sideThree)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideOne, sideTwo, sideThree));
        }

        [TestCase(-40, 40, 9)]
        [TestCase(5, -6, 7)]
        [TestCase(1230, 321, -1230)]
        public void IsValidTriangle_WhenNegativeSides_ShouldArgumentException(double sideOne, double sideTwo, double sideThree)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideOne, sideTwo, sideThree));
        }

        [TestCase(40, 40, 9, 178.8573104460648)]
        [TestCase(5, 6, 7, 14.696938456699069)]
        [TestCase(1230, 321, 1230, 195727.08485270376)]
        public void GetArea_WhenValidSides_ShouldPositiveArea(
            double sideOne, double sideTwo, double sideThree, double expected)
        {
            // Arrange
            var triangle = new Triangle(sideOne, sideTwo, sideThree);

            // Act
            var area = triangle.GetArea();

            // Assert
            Assert.That(area, Is.EqualTo(expected));
        }

        [TestCase(40, 40, 9)]
        [TestCase(5, 6, 7)]
        [TestCase(1230, 321, 1230)]
        public void IsRightAngledTriangle_WhenValidSides_ShouldFalse(double sideOne, double sideTwo, double sideThree)
        {
            // Arrange & Act & Assert
            Assert.That(new Triangle(sideOne, sideTwo, sideThree).IsRightAngledTriangle, Is.False);
        }

        [TestCase(3, 4, 5)]
        [TestCase(30, 4, 30.265491900843113)]
        [TestCase(30.27, 1234, 1234.3712054726486)]
        public void IsRightAngledTriangle_WhenValidSides_ShouldTrue(double sideOne, double sideTwo, double sideThree)
        {
            // Arrange & Act & Assert
            Assert.That(new Triangle(sideOne, sideTwo, sideThree).IsRightAngledTriangle, Is.True);
        }
    }
}
