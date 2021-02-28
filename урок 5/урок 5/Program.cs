using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            Console.WriteLine("Please write a number...");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = Sum(number1, number2);
            Console.WriteLine("The sum of your numbers is: " + result);

        }
        static void DisplayName()
        {
            Console.WriteLine("My name is Anton");
        }

        static void DisplayGivenName(string name)
        {
            Console.WriteLine("Your name is " + name);
        }
        static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }


    }
}