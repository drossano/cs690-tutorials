using System.Runtime.ConstrainedExecution;

namespace exceptions;

class Program
{
    static void Main(string[] args)
    {
        string mySentence = "";
        string result = FirstWord(mySentence);
        Console.WriteLine(result);

    }

    public static string FirstWord(string sentence)
    {
        if (sentence == "")
        {
            throw new ArgumentException("Empty sentence!");
        }
        string[] splitted = sentence.Split(" ");
        return splitted[0];
    }
}
