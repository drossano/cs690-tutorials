namespace list;

class Program
{
    static void Main(string[] args)
    {
        List<int> someNumbers = new List<int>();
        someNumbers.Add(4);
        someNumbers.Add(5);
        someNumbers.Add(-1);

        Console.WriteLine("Before Removal: ");
        foreach (int num in someNumbers)
        {
            Console.WriteLine(num);
        }

        someNumbers.Remove(5);
        // List.Add() adds an item
        Console.WriteLine("After Removal: ");
        foreach (int num in someNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
