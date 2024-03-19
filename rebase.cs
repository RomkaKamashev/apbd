using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int maxValue = FindMaxValue(numbers);
        Console.WriteLine("Maximum Value: " + maxValue);
    }

    // Method to find the maximum value in an array of integers
    static int FindMaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array is empty or null. Cannot find maximum value.");
        }

        return numbers.Max();
    }
}
