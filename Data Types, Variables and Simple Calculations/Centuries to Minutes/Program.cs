int centuries = int.Parse(Console.ReadLine());

// Conversion constants
const int yearsPerCentury = 100;
const double daysPerYear = 365.2422;
const int hoursPerDay = 24;
const int minutesPerHour = 60;

// Perform conversions
int years = centuries * yearsPerCentury;
double days = (int)Math.Floor(years * daysPerYear);
int hours = (int)days * hoursPerDay;
int minutes = hours * minutesPerHour;

// Print results
Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");