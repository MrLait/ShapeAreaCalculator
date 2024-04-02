using ShapeAreaCalculatorLib.Interfaces;

namespace ShapeAreaCalculatorLib
{
    public class ContextAreaCalculator
    {
        private IAreaCalculator? _areaCalculator;

        public ContextAreaCalculator(){}

        public ContextAreaCalculator(IAreaCalculator areaCalculator)
        {
            SetStrategy(areaCalculator);
        }

        public void SetStrategy(IAreaCalculator strategy)
        {
            ValidateStrategy(strategy);
            _areaCalculator = strategy;
        }

        public double GetArea()
        {
            if (_areaCalculator == null)
            {
                throw new InvalidOperationException("Context Error: strategy instance is null.");
            }

            return _areaCalculator.GetArea();
        }

        private static void ValidateStrategy(IAreaCalculator strategy)
        {
            ArgumentNullException.ThrowIfNull(strategy);
        }
    }
}
