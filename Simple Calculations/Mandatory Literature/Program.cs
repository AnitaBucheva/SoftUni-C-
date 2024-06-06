int pages = int.Parse(Console.ReadLine());
int pagesInHours = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int totalReadingTime = pages / pagesInHours;
int hoursPerDay = totalReadingTime /days;

Console.WriteLine(hoursPerDay);