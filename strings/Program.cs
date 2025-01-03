namespace strings;

class Program
{
    static void Main(string[] args)
    {
        string example = "Hello World!";

        char myChar = 'H';

        char firstLetter = example[0];

        bool result = myChar == firstLetter;

        Console.WriteLine(result);


        foreach (char letter in example)
        {
            Console.WriteLine(letter);
        }

    }
}
