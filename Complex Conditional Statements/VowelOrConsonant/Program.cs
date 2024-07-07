using System;

class Program
{
    static void Main()
    {
        // Read a character from the console
      
        char letter = Console.ReadLine()[0];

        // Check if the character is a vowel
        if ("AEIOUaeiou".IndexOf(letter) >= 0)
        {
            Console.WriteLine("Vowel");
        }
        else if (char.IsLetter(letter))
        {
            Console.WriteLine("Consonant");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
