using ShapeAreaCalculatorLib.Enums;
using ShapeAreaCalculatorLib.Interfaces;

namespace ShapeAreaCalculatorLib.Shapes
{
    public class Triangle : IShape
    {
        private readonly double[] _sides;

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            IsValidTriangle(sideOne, sideTwo, sideThree);   
            _sides = [sideOne, sideTwo, sideThree];
        }

        public bool IsRightAngledTriangle 
        { 
            get 
            {
                Array.Sort(_sides);
               
                var sideOne = _sides[(int)TriangleSides.SideOne];
                var sideTwo = _sides[(int)TriangleSides.SideTwo];
                var hypotenuse = _sides[(int)TriangleSides.SideThree];
                
                var leftPifagorResult = Math.Round( Math.Pow(sideOne, 2) + Math.Pow(sideTwo, 2), 6);
                var rightPifagorResult = Math.Round(Math.Pow(hypotenuse, 2), 6);

                return leftPifagorResult == rightPifagorResult;
            }
        }

        public double GetArea()
        {
            double semiPerimeter = _sides.Sum() / 2;
            return Math.Sqrt(semiPerimeter * 
                (semiPerimeter - _sides[(int)TriangleSides.SideOne]) * 
                (semiPerimeter - _sides[(int)TriangleSides.SideTwo]) * 
                (semiPerimeter - _sides[(int)TriangleSides.SideThree]));
        }

        private static void IsValidTriangle(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne <= 0 || sideTwo <= 0 || sideThree <= 0)
                throw new ArgumentException("Triangle Error: The sides of a triangle cannot be zero or less.");

            double[] sides = [sideOne, sideTwo, sideThree];
            Array.Sort(sides);

            if (!(sides[(int)TriangleSides.SideOne] + sides[(int)TriangleSides.SideTwo] > sides[(int)TriangleSides.SideThree]))
                throw new ArgumentException("Triangle Error: Unable to construct a triangle with the entered side lengths.");
        }
    }
}
