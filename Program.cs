using System.Globalization;

while true {
    Random gen = new Random();
    //list difficulty
    Console.WriteLine("1)   easy");
    Console.WriteLine("2)   medium");
    Console.WriteLine("3)   hard");
    Console.Write("Which difficulty?    ")
    //sets the max random number
    int diff = Convert.ToInt32(Console.ReadLine());
    int max = 0;
    if (diff == 1) {
        max = 10;
    }
    else if (diff == 1) {
        max = 50;
    }
    else if (diff == 1) {
        max = 100;
    }
    int choice = -1;
    int num = gen.Next(0, max);
    do while (choice != num) {
        Console.Write("")
    }
}