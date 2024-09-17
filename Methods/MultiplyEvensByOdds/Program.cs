using System;

class Program
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        int result = GetMultipleOfEvenAndOdds(number);
        Console.WriteLine($"{result}");
    }

    static int GetMultipleOfEvenAndOdds(int number)
    {
        int sumEven = GetSumOfEvenDigits(number);
        int sumOdd = GetSumOfOddDigits(number);

        return sumEven * sumOdd;
    }

    static int GetSumOfEvenDigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number); // Ensure positive number for calculation

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }
            number /= 10;
        }

        return sum;
    }

    static int GetSumOfOddDigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number); // Ensure positive number for calculation

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                sum += digit;
            }
            number /= 10;
        }

        return sum;
    }
}
