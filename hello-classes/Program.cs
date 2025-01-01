using System.Dynamic;

namespace hello_classes;

class Program
{
    static void Main(string[] args)
    {
        string userInput;

        Building myBuilding = new Building(5);
        myBuilding.Display();

        do
        {
            Console.WriteLine("Type add, remove, or end");
            userInput = Console.ReadLine();

            if (userInput == "add")
            {
                myBuilding.AddOneFloor();
            }
            else if (userInput == "remove")
            {
                myBuilding.RemoveOneFloor();
            }

            // display building

            myBuilding.Display();
        } while (userInput != "end");
    }



}


public class Building
{
    int height;

    public Building(int initialHeight)
    {
        this.height = initialHeight;
    }

    public void AddOneFloor()
    {
        this.height += 1;
    }

    public void RemoveOneFloor()
    {
        this.height -= 1;
    }
    public void Display()
    {
        for (int i = 0; i < height; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("-----");
            }
            else
            {
                Console.WriteLine("*****");
            }

        }

    }
}
