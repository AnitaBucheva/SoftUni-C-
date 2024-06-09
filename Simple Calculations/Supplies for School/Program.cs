int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int cleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double totalPrice = pens * 5.80 + markers * 7.20 + cleaner * 1.20;

double discountAmount = totalPrice * discount / 100;
double final = totalPrice - discountAmount;
Console.WriteLine(final);