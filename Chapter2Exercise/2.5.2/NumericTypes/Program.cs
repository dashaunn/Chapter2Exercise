using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            string lengthInput;
            string widthInput;

            Console.WriteLine("What is the length of the rectangle?");
            lengthInput = Console.ReadLine();
            length = int.Parse(lengthInput);

            Console.WriteLine("Nice. What is the width of the rectangle?");
            widthInput = Console.ReadLine();
            width = int.Parse(widthInput);

            Console.WriteLine("The area of the rectangle is: " + (length * width));
            
        }
    }
}

