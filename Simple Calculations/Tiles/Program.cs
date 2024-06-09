double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeigh = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeigh = double.Parse(Console.ReadLine());

double bathroomArea = bathroomWidth * bathroomHeigh;
double surplus = bathroomArea * 0.1;
double totalBath = bathroomArea + surplus;
double tileArea = tileWidth * tileHeigh;

double tilesNeeded = totalBath / tileArea;
Console.WriteLine($"{tilesNeeded:F0}");