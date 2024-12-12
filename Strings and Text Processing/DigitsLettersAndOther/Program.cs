using System.Text;

//1. входни данни
string text = Console.ReadLine(); //"Agd#53Dfg^&4F53"

//цифри
StringBuilder sbDigits = new StringBuilder();

//букви (главни и малки)
StringBuilder sbLetters = new StringBuilder();

//други символи
StringBuilder sbOthers = new StringBuilder();

foreach (char symbol in text)
{
    //проверка дали цифра или буква
    //symbol = 'A'

    if (char.IsLetter(symbol))
    {
        sbLetters.Append(symbol);
    }
    else if (char.IsDigit(symbol))
    {
        sbDigits.Append(symbol);
    }
    else
    {
        sbOthers.Append(symbol);
    }
}

//sbDigits -> всички цифри от текста
//sbLetters -> всички букви от текста
//sbOthers -> всички останали символи

Console.WriteLine(sbDigits);
Console.WriteLine(sbLetters);
Console.WriteLine(sb);




using System;

class Program
{
    static void Main()
    {
        // Read the input string from the console
        string input = Console.ReadLine();

        // Initialize strings to store the digits, letters and other characters
        string digits = "";
        string letters = "";
        string others = "";

        // Iterate through each character in the input string
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                digits += c;
            }
            else if (char.IsLetter(c))
            {
                letters += c;
            }
            else
            {
                others += c;
            }
        }

        // Print the results
        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(others);
    }
}
