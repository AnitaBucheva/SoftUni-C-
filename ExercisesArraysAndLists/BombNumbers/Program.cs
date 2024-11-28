List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int[] bombinfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

int bombNumb = bombinfo[0];
int bombPower = bombinfo[1];

for (int i = 0; i < numbers.Count; i++)
{
    int currentnumber = numbers[i];

    if (currentnumber == bombNumb)
    {
        int startIndex = i - bombPower;
        int ednIndex = i + bombPower;

        if (startIndex < 0)
        {
            startIndex = 0;
        }
        if(ednIndex > numbers.Count - 1) {
            ednIndex = numbers.Count - 1;
        }
        int countToRemove = ednIndex - startIndex + 1;

        numbers.RemoveRange(startIndex, countToRemove);

        i = startIndex - 1;
    }
}
Console.WriteLine(numbers.Sum());