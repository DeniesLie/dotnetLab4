namespace CaloriesCalculatorCore;

public interface ICaloriesCalculator
{
    /// <summary>
    /// Method that calculates daily norm of kilocalories for person
    /// </summary>
    /// <returns>
    /// Number of kilocalories
    /// </returns>
    int Calculate();
}