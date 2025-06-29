using System;

namespace FinancialForecasting
{
    class Program
    {
        // Step 2 & 3: Recursive Future Value Prediction
        static double PredictFutureValue(double initialValue, double growthRate, int years)
        {
            if (years == 0)
                return initialValue;
            return PredictFutureValue(initialValue * (1 + growthRate), growthRate, years - 1);
        }

        // Step 4: Optimized using iteration (optional)
        static double PredictFutureValueIterative(double initialValue, double growthRate, int years)
        {
            double result = initialValue;
            for (int i = 0; i < years; i++)
            {
                result *= (1 + growthRate);
            }
            return result;
        }

        static void Main(string[] args)
        {
            double initial = 1000.0;
            double rate = 0.1; // 10% growth
            int futureYears = 5;

            Console.WriteLine("Recursive Forecast:");
            Console.WriteLine($"Future Value after {futureYears} years: {PredictFutureValue(initial, rate, futureYears):F2}");

            Console.WriteLine("\nOptimized Iterative Forecast:");
            Console.WriteLine($"Future Value after {futureYears} years: {PredictFutureValueIterative(initial, rate, futureYears):F2}");
        }
    }
}
