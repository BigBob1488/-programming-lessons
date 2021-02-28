using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //    int count = 5;
            //    while (true)
            //{
            //    Console.WriteLine("шо" + count);
            //}

            //while(count-- > 0)

            //{ 
            //    Console.WriteLine("шо" + count);

            //}
            //for (; ;)
            //{

            //Console.WriteLine("We are on theiteration");


            //}

            //do
            //{

            //    Console.WriteLine("шо" + count);


            //}
            //while (count++ < 20);
            Console.WriteLine("Please choose the door");
            string choice = ""; 
            while (choice != "exit") 
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": // choice == 1
                        Console.WriteLine("You chose the door with enemy");
                        break;
                    case "2": // choice == 2
                        Console.WriteLine("You chose the door with treasure!!! Congratulation");
                        break;
                    case "3":
                    case "4":
                    case "5":
                        Console.WriteLine("This is empty door");
                        break;
                    default:
                        Console.WriteLine("There is no such door");
                        break;

                }















            }
        } }}
             
