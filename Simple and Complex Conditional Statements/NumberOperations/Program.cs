using System;

namespace MathOperationEvaluator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the first real number
            
            double number1 = ReadDouble();

            // Read the second real number
        
            double number2 = ReadDouble();

            // Read the math operator
      
            string mathOperator = Console.ReadLine();

            // Perform the operation and print the result
            double result;
            bool isValidOperator = true;
            switch (mathOperator)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    isValidOperator = false;
                    result = 0;
                    break;
            }

            // Print the result if the operator was valid
            if (isValidOperator)
            {
                Console.WriteLine($"{number1} {mathOperator} {number2} = {result:F2}");
            }
        }

        static double ReadDouble()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return number;
        }
    }
}
