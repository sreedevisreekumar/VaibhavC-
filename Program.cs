using System;

namespace E06_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            MeetAlien();
            Console.WriteLine("----------------------");
            MeetAlien();
            Console.ReadLine();
        }

        static void MeetAlien()
        {
            Random numberGen = new Random();
            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 999);
            Console.WriteLine("Hello, my name is " + name);
            Console.WriteLine("I am " + age + "years old");

               
        }
    }
}
