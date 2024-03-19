using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        try
        {
            double average = CalculateAverage(numbers);
            Console.WriteLine("Average: " + average);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
    static double Calculate(int[] numbers)
    {
        if (number == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array is empty or null. Cannot calculate average.");
        }

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return (double)sum / numbers.Length;
    }
}
