namespace CaloriesCalculatorCore.CalculatorDecorators;

public class WeightDecorator : BaseDecorator
{
    private const float WeightCoefficient = 1.05f;
    private const float MedianWeight = 1.7f;
    
    private readonly float _weight;
    
    public WeightDecorator(ICaloriesCalculator calculator, float weight)
        : base(calculator)
    {
        _weight = weight;
    }
    
    public override int Calculate()
    {
        var result = base.CaloriesCalculator.Calculate();
        var delta = (MedianWeight - _weight) * WeightCoefficient;
        result += (int)delta;
        return result;
    }
}