using System;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new ImageStatisticsCalculator();
        calculator.CalculateStatistics("lena.jpg");
        Console.WriteLine($"Mean: {calculator.Mean}");
        Console.WriteLine($"Standard deviation: {calculator.StandardDeviation}");
        Console.WriteLine($"Minimum value: {calculator.MinValue}");
        Console.WriteLine($"Maximum value: {calculator.MaxValue}");
    }
}
