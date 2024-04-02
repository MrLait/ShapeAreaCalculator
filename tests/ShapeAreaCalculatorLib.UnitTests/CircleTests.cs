using ShapeAreaCalculatorLib.Shapes;

namespace ShapeAreaCalculatorLibTests
{
    [TestFixture]
    public class CircleTests
    {

        [TestCase(1)]
        [TestCase(25)]
        [TestCase(int.MaxValue)]
        public void GetArea_WhenValidRadius_ShouldReturnsCorrectArea(double radius)
        {
            // Arrange
            var circle = new Circle(radius);
            var expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            double actualArea = circle.GetArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void GetArea_WhenRadiusEqualZeroOrLess_ShouldThrowArgumentException(double radius)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}