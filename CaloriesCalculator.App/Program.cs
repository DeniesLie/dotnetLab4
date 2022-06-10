using CaloriesCalculatorCore;
using CaloriesCalculatorCore.CalculatorDecorators;
using CaloriesCalculatorCore.Enums;

ICaloriesCalculator calculator = new CaloriesCalculator(Gender.Male); 
calculator = new HeightDecorator(calculator, 1.76f);
calculator = new PhysicalActivityDecorator(calculator, PhysicalActivityType.Medium);
calculator = new StatureDecorator(calculator, StatureType.Endomorph);
calculator = new WeightDecorator(calculator, 65f);

Console.WriteLine($"Your result: {calculator.Calculate()}");