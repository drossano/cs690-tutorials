using System.Diagnostics;

namespace classes;


class Program
{
    static void Main(string[] args)
    {
        Stopwatch myWatch = new();
        myWatch.Start();
        for (int i = 0; i < 100000; i++)
        {
            Console.WriteLine("Hello, world!");
        }

        myWatch.Stop();

        TimeSpan elapsed = myWatch.Elapsed;

        Console.WriteLine(elapsed);
    }
}
