namespace math;

class Program
{
    static void Main(string[] args)
    {
        Random myRandom = new Random();

        do
        {
            int someRandomNum = myRandom.Next(4, 10);

            Console.WriteLine(someRandomNum);
        } while (true);
    }
}
