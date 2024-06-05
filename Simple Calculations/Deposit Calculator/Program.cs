double deposit = double.Parse(Console.ReadLine());
double interest = double.Parse(Console.ReadLine());
int mount = int.Parse(Console.ReadLine());

double mountlyInterest = deposit * interest / 100 / 12;
double totalAmount = deposit + mountlyInterest * mount;
Console.WriteLine($"{totalAmount:F2}");