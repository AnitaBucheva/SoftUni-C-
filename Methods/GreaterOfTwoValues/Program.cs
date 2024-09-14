using System;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        string firstValue = Console.ReadLine();
        string secondValue = Console.ReadLine();

        switch (type)
        {
            case "int":
                int intFirst = int.Parse(firstValue);
                int intSecond = int.Parse(secondValue);
                Console.WriteLine(GetMax(intFirst, intSecond));
                break;

            case "char":
                char charFirst = char.Parse(firstValue);
                char charSecond = char.Parse(secondValue);
                Console.WriteLine(GetMax(charFirst, charSecond));
                break;

            case "string":
                Console.WriteLine(GetMax(firstValue, secondValue));
                break;
        }
    }

    static int GetMax(int a, int b)
    {
        return a > b ? a : b;
    }

    static char GetMax(char a, char b)
    {
        return a > b ? a : b;
    }

    static string GetMax(string a, string b)
    {
        return string.Compare(a, b) > 0 ? a : b;
    }
}
