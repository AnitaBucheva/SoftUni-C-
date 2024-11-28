List<int> firstList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> secondtList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> output = new List<int>();

int interation = 0;
if (firstList.Count > secondtList.Count)
{
    interation = firstList.Count;
}
else
{
    interation = secondtList.Count;
}

    for(int i = 0; i < interation; i++)
    {
        if(i < firstList.Count)
        {
            int curElemFirstList = firstList[i];
            output.Add(curElemFirstList);
        }
        if(i < secondtList.Count)
        {
            int curElemSecondList = secondtList[i];
            output.Add(curElemSecondList);
        }
        
    }
    Console.WriteLine(string.Join(" ", output));

