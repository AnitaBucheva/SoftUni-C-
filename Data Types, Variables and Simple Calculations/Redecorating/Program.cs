int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hoursNeeded = int.Parse(Console.ReadLine());

double priseNaylon = (nylon + 2) * 1.5;
double pricePaint = (paint * 1.1) * 14.5;
double priceTinner = thinner * 5;
double bags = 0.4;

double totalAmount = priseNaylon + pricePaint + priceTinner + bags;
double craftsmen = 0.3 * totalAmount;
double all = craftsmen * hoursNeeded;
double totalPrice = totalAmount + all;

Console.WriteLine($"{totalPrice}");