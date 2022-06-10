using CaloriesCalculatorCore.Enums;

namespace CaloriesCalculatorCore.CalculatorDecorators;

public class StatureDecorator : BaseDecorator
{
    private readonly StatureType _statureType;
    
    public StatureDecorator(ICaloriesCalculator calculator, 
                            StatureType statureType)
        : base(calculator)
    {
        _statureType = statureType;
    }
    
    public override int Calculate()
    {
        var result = base.CaloriesCalculator.Calculate();
        switch (_statureType)
        {
            case StatureType.Ectomorph:
                result += 100;
                break;
            case StatureType.Endomorph:
                result -= 50;
                break;
            case StatureType.Mesomorph:
                result -= 150;
                break;
        }
        return result;
    }
}