using CaloriesCalculatorCore.Enums;

namespace CaloriesCalculatorCore.CalculatorDecorators;

public class PhysicalActivityDecorator : BaseDecorator
{
    private readonly PhysicalActivityType _physicalActivity;
    
    public PhysicalActivityDecorator(ICaloriesCalculator calculator, 
                                     PhysicalActivityType physicalActivity)
        : base(calculator)
    {
        _physicalActivity = physicalActivity;
    }
    
    public override int Calculate()
    {
        var result = base.CaloriesCalculator.Calculate();
        switch (_physicalActivity)
        {
            case PhysicalActivityType.Low:
                result -= 200;
                break;
            case PhysicalActivityType.Medium:
                result += 300;
                break;
            case PhysicalActivityType.High:
                result += 500;
                break;
        }
        return result;
    }
}