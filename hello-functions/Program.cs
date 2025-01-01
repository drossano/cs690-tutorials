namespace hello_functions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        string firstInput = Console.ReadLine();
        int firstNumber = int.Parse(firstInput);

        // Console.WriteLine("Enter amother number: ");
        // string secondInput = Console.ReadLine();
        // int secondNumber = int.Parse(secondInput);

        // int result = Add(firstNumber, secondNumber);

        // Console.WriteLine(result);
        bool prime = IsPrime(firstNumber);
        Console.WriteLine(prime);

        PrintSomething();
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static bool IsPrime(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    // use void to write functions with no return values
    public static void PrintSomething()
    {
        Console.WriteLine("Hello, World!");
    }
}
