using System;

namespace Data_tipes
{
    class Program
    {
        static void Main(string[] args)
        {
            double age;
            string name;
            int birthYear;

            //Console.WriteLine("What is youre name");
            //name = Console.ReadLine();

            //Console.WriteLine("User's name is: " + name);

            //Console.WriteLine("How old are you");
            //age = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Age = " + age);

             Console.WriteLine("When you were born?");
            birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Was born in " + birthYear);
            Console.WriteLine("Size of double is: " + sizeof(double));
            double  upYear = (double)birthYear / 4;
            Console.WriteLine("Result: " + upYear);



        }
    }
}
