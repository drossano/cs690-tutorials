namespace hello_loops;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Pleas enter a number");
        // string input = Console.ReadLine();
        // int numInput = int.Parse(input);

        // for (int i = 0; i < numInput; i++)
        // {
        //     Console.WriteLine(i);
        // }

        int numInput;
        string input;
        int sum = 0;
        // needs to be defined outside of loop to be accessed by while clause
        do
        {
            Console.WriteLine("Pleas enter a number (enter end to exit)");
            input = Console.ReadLine();

            if (input != "end")
            {
                numInput = int.Parse(input);
                sum += numInput;
            }


        } while (input != "end");
        Console.WriteLine("Sum = " + sum);
    }
}
