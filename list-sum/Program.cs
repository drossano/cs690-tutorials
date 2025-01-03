namespace list_sum;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersFromUser = [];
        string userinput;
        do
        {
            Console.WriteLine("Enter a number (enter END to finish): ");
            userinput = Console.ReadLine();
            if (userinput != "END")
            {
                int numInput = int.Parse(userinput);
                numbersFromUser.Add(numInput);

            }
        } while (userinput != "END");


        foreach (int num in numbersFromUser)
        {
            Console.WriteLine(num);
        }

        int sum = SumOfNumbers(numbersFromUser);
        Console.WriteLine(sum);
    }
    public static int SumOfNumbers(List<int> input)
    {
        int result = 0;
        foreach (int num in input)
        {
            result += num;
        }
        return result;
    }
}


