string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

Console.WriteLine(Repeat(text, count));

static string Repeat(string text, int count)
{
    string result = "";
    for (int i = 1; i <= count; i++)
    {
        result += text;
    }
    return result;
}