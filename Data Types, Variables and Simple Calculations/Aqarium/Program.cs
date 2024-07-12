using System;

class Program
{
    static void Main()
    {
        // Read input
        int length = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double percentage = double.Parse(Console.ReadLine());

        // Calculate volume of the aquarium in cubic centimeters
        double volumeCm3 = length * width * height;

        // Calculate volume occupied by sand, plants, heater, and pump
        double occupiedVolume = volumeCm3 * (percentage / 100);

        // Calculate remaining volume for water
        double waterVolumeCm3 = volumeCm3 - occupiedVolume;

        // Convert volume to liters
        double waterVolumeLiters = waterVolumeCm3 / 1000;

        // Print result
        Console.WriteLine($"{waterVolumeLiters:F2}");
    }
}
