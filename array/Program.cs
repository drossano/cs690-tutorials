namespace array;

class Program
{
    static void Main(string[] args)
    {
        List<int> someNumbers = new List<int>();

        // empty array on length 10
        int[] myArray = new int[10];

        myArray[0] = 3;
        myArray[1] = 2;
        myArray[2] = 1;

        List<int> listVersion = myArray.ToList();

    }
}
