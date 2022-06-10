using CaloriesCalculatorCore.Enums;

namespace CaloriesCalculatorCore;

public class CaloriesCalculator : ICaloriesCalculator
{
    private const int MaleNorm = 2600;
    private const int FemaleNorm = 2000;
    private readonly Gender _gender;
    
    public CaloriesCalculator(Gender gender)
    {
        _gender = gender;
    }
    
    public int Calculate()
    {
        if (_gender == Gender.Female)
            return FemaleNorm;
        
        return MaleNorm;
    }
}