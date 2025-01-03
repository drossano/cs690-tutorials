namespace files;

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string contents = File.ReadAllText("numbers.txt");
        string[] result = contents.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;
        foreach (string item in result)
        {
            int numAsNum = int.Parse(item);
            sum += numAsNum;
        }

        Console.WriteLine(sum);
    }
}
