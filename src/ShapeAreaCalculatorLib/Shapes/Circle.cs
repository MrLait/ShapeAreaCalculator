using ShapeAreaCalculatorLib.Interfaces;

namespace ShapeAreaCalculatorLib.Shapes
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            ValidateCircle(radius);
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        private void ValidateCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException($"Circle Error: Radius can't be zero or less");
            }
        }
    }
}
