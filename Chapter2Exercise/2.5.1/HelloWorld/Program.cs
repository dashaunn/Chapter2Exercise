using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello stranger! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Howdy! Nice to meet you, " + name + ". :)");
        }
    }
}

