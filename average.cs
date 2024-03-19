using System;

class Program
{
    static void Main()
    {
        int[] number = { 1, 2, 3, 4, 5 };
        try
        {
            double average = CalculateAver(number);
            Console.WriteLine("Average: " + average);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
    static double CalculateAver(int[] number)
    {
        if (number == null || number.Length == 0)
        {
            throw new ArgumentException("Array is empty or null. Cannot calculate average.");
        }

        int sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            sum += number[i];
        }

        return (double)sum / number.Length;
    }
}
