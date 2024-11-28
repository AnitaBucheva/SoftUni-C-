int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int iterations = numbers.Length / 2;

List<int> result = new List<int>();

for (int i = 0; i < iterations; i++)
{
    int currentNum = numbers[i] + numbers[numbers.Length - 1 - i];
    result.Add(currentNum);
}
if(numbers.Length % 2 != 0)
{
    int index = numbers.Length / 2; 
    result.Add(numbers[index]);
}
Console.WriteLine(string.Join(" ", result));