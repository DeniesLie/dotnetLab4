namespace CaloriesCalculatorCore.CalculatorDecorators;

public abstract class BaseDecorator : ICaloriesCalculator
{
    protected ICaloriesCalculator CaloriesCalculator;

    public BaseDecorator(ICaloriesCalculator caloriesCalculator)
    {
        CaloriesCalculator = caloriesCalculator;
    }
    public abstract int Calculate();
}