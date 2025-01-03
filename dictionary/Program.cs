namespace dictionary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an abbreviation:");
        string input = Console.ReadLine();
        string result = ExpandedAbbreviation(input);
        Console.WriteLine(result);
    }

    public static string ExpandedAbbreviation(string abbreviation)
    {
        Dictionary<string, string> popular = new()
        {
            ["lol"] = "laugh out loud",
            ["brb"] = "be right back",
            ["omg"] = "oh my god",
            ["fyi"] = "for your information"
        };

        if (popular.ContainsKey(abbreviation))
        {
            return popular[abbreviation];
        }
        else
        {
            return "Not found";
        }
    }
}
