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
            Console.Write("enter a number>  ");
            choice = Convert.ToInt32(Console.ReadLine());
            //determine if it is greater or less than the number
            if (choice > num)
            {
                Console.WriteLine("Too high, try again.")
            }
            else if (choice < num)
            {
                Console.WriteLine("Too low, try again.")
            }
        }
    Console.WriteLine("You Win!")
}