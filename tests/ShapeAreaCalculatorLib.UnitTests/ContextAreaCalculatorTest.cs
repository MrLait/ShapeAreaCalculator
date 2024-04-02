using Moq;
using ShapeAreaCalculatorLib.Interfaces;
using ShapeAreaCalculatorLib.Shapes;

namespace ShapeAreaCalculatorLib.UnitTests
{
    [TestFixture]
    public class ContextAreaCalculatorTest
    {
        [Test]
        public void GetArea_WhenStategyIsNull_ShouldInvalidOperationException()
        {
            //Arrange
            var context = new ContextAreaCalculator();

            //Act & Assert 
            Assert.Throws<InvalidOperationException>(() => context.GetArea());
        }

        [Test]
        public void Constructor_WhenStategyIsNull_ShouldArgumentNullException()
        {
            //Arrange & Act & Assert 
            Assert.Throws<ArgumentNullException>(() => new ContextAreaCalculator(null));
        }


        [TestCase(25)]
        public void GetArea_WhenStategyIsValid_ShouldReturnSameArea(double expectedArea)
        {
            //Arrange
            var mockStrategy = new Mock<IAreaCalculator>();
            mockStrategy.Setup(x => x.GetArea()).Returns(expectedArea);
            var context = new ContextAreaCalculator(mockStrategy.Object);

            //Act
            var actualArea = context.GetArea();

            //Assert 
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        public void SetStrategy_WhenStategyIsNull_ShouldArgumentNullException()
        {
            //Arrange
            var context = new ContextAreaCalculator();

            //Act & Assert 
            Assert.Throws<ArgumentNullException>(() => context.SetStrategy(null));
        }

        [Test]
        public void SetStrategy_WhenStrategyIsValid_ShouldReturnAreEqualStrategy()
        {
            // Arrange
            var mockStrategy= new Mock<IAreaCalculator>();
            var calculator = new ContextAreaCalculator();

            // Act
            calculator.SetStrategy(mockStrategy.Object);

            // Assert
            Assert.That(GetStrategy(calculator), Is.EqualTo(mockStrategy.Object));
        }

        [TestCase(5)]
        [TestCase(25)]
        [TestCase(int.MaxValue)]
        public void GetArea_WhenStrategyIsCircle_ShouldPositiveArea(double radius)
        {
            //Arrange 
            var context = new ContextAreaCalculator(new Circle(radius));
            var expectedArea = Math.PI * Math.Pow(radius, 2);

            //Act 
            var actualArea = context.GetArea();

            //Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void GetArea_WhenStrategyIsCircleWithNegativeOrEqualZero_ShouldArgumentException(double radius)
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new ContextAreaCalculator(new Circle(radius)));
        }

        [TestCase(40, 40, 9, 178.8573104460648)]
        [TestCase(5, 6, 7, 14.696938456699069)]
        [TestCase(1230, 321, 1230, 195727.08485270376)]
        public void GetArea_WhenStrategyIsTriangle_ShouldPositiveArea(
            double sideOne, double sideTwo, double sideThree, double expected)
        {
            //Arrange 
            var context = new ContextAreaCalculator(new Triangle(sideOne, sideTwo, sideThree));

            //Act 
            var actualArea = context.GetArea();

            //Assert
            Assert.That(actualArea, Is.EqualTo(expected));
        }

        [TestCase(400, 40, 9)]
        [TestCase(50, 6, 7)]
        [TestCase(1230, 32100, 1230)]
        [TestCase(0, 0, 0)]
        [TestCase(-40, 40, 9)]
        [TestCase(5, -6, 7)]
        [TestCase(1230, 321, -1230)]
        public void GetArea_WhenStrategyIsTriangleWithNegativeOrEqualZero_ShouldArgumentException(
            double sideOne, double sideTwo, double sideThree)
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentException>
                (
                    () => new ContextAreaCalculator(new Triangle(sideOne, sideTwo, sideThree))
                );
        }

        private static IAreaCalculator? GetStrategy(ContextAreaCalculator calculator)
        {
            var field = calculator
                .GetType()
                .GetField(
                "_areaCalculator", 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return field?.GetValue(calculator) as IAreaCalculator;
        }
    }
}
