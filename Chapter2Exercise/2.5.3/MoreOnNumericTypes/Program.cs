using System;

namespace MoreOnNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string milesInput;
            string gasInput;
            int miles;
            int gas;

            Console.WriteLine("Jeez, it looks like you've been travelling for ages in that thing! How many miles was your trip?");
            milesInput = Console.ReadLine();
            miles = int.Parse(milesInput);
            Console.WriteLine("How many gallons of gas did that cost you?");
            gasInput = Console.ReadLine();
            gas = int.Parse(gasInput);
            Console.WriteLine("Really? That thing can do " + (miles/gas) + " miles per gallon!?");

        }
    }
}

