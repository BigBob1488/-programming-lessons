using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool isAlive = true;

            if (isAlive)
            {
                Console.WriteLine("Player is alive");
            }
            else
            {
                Console.WriteLine("Player is dead :(");
            }

            bool fullHP = false, fullAmmo = true;

            if(fullHP|| fullAmmo)
            {
                Console.WriteLine("Player has fullHP or FullAmmo");

            }
            Console.WriteLine("Please choose the door");
                int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("You chose the door with enemy");
                    break;
                case 2:
                    Console.WriteLine("You chose the door with treasure!!!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("This is empy door");
                    break;
                default:
                    Console.WriteLine("There is no such door");
                    break;

            }
        }
    }
}
