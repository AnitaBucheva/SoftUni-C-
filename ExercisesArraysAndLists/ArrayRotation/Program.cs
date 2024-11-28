int[] numArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int firstEle = numArr[0];
    for (int j = 1; j < numArr.Length; j++)
    {
        numArr[j-1]= numArr[j];

    }
    numArr[numArr.Length-1]= firstEle;
}
Console.WriteLine(string.Join(" ", numArr));