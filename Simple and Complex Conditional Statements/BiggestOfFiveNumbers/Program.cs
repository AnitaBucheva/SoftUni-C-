int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());
int num5 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
{
    Console.WriteLine(num1);
}
if (num2 > num1 && num2 > num3 && num2 > num4  && num2 > num5)
{
    Console.WriteLine(num2);
}
if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
{
    Console.WriteLine(num3);
}
if (num4 > num1 && num4 > num3 && num4 > num2 && num4 > num5)
{
    Console.WriteLine(num4);
}
if (num5 > num1 && num5 > num3 && num5 > num4 && num5 > num2)
{
    Console.WriteLine(num5);
}