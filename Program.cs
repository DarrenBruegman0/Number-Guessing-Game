using System.Globalization;

while (true)
{
    Random gen = new Random();
    //list difficulty
    Console.WriteLine("1)   easy");
    Console.WriteLine("2)   medium");
    Console.WriteLine("3)   hard");
    //sets the max random number
    string diffString = "";
    int diff = 0;
    while (diff > 3 || diff < 1)
    {
    Console.Write("Which difficulty?    ");
    diffString = Console.ReadLine();
    int.TryParse(diffString, out diff);
    }

    int max = 0;
    //set difficulty
    if (diff == 1)
    {
        max = 10;
    }
    else if (diff == 2)
    {
        max = 50;
    }
    else if (diff == 3)
    {
        max = 100;
    }
    int choice = -1;
    int num = gen.Next(0, max);
    do
    {
        string c = "";
        while (!int.TryParse(c, out choice))
        {
            Console.Write("enter a number>  ");
            c = Console.ReadLine();
        }
        //determine if it is greater or less than the number
        if (choice > num)
        {
            Console.WriteLine("Too high, try again.");
        }
        else if (choice < num)
        {
            Console.WriteLine("Too low, try again.");
        }
    } while (choice != num);
    Console.WriteLine("You Win!");

}
