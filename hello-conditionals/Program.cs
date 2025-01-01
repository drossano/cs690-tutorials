namespace hello_conditionals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your password.");
        string thePassword = Console.ReadLine();

        if (thePassword == "hunter7")
        {
            Console.WriteLine("Correct password, you're in");
        }
        else if (thePassword == "hunter")
        {
            Console.WriteLine("Close, but no cigar");
        }
        else
        {
            Console.WriteLine("Wrong password, try again");
        }
    }
}
