namespace CaloriesCalculatorCore.CalculatorDecorators;

public class HeightDecorator : BaseDecorator
{
    private const float HeightCoefficient = 1.03f;
    private const float MedianHeight = 1.7f;
    
    private readonly float _height;
    
    public HeightDecorator(ICaloriesCalculator calculator, float height)
        : base(calculator)
    {
        _height = height;
    }
    
    public override int Calculate()
    {
        var result =base.CaloriesCalculator.Calculate();
        var delta = (_height - MedianHeight) * HeightCoefficient;
        result += (int)delta;
        return result;
    }
}