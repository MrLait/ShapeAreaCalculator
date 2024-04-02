namespace ShapeAreaCalculatorLib.Interfaces
{
    internal interface IShape: IAreaCalculator
    {
        new double GetArea();
    }
}
