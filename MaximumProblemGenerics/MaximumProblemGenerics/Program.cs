using System;
namespace MaximumProblemGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Maximum Problem using Generics!");
            string TC1 = MaximumNumberCheck.MaximumNumber("Apple", "Peach", "Banana");
            string TC2 = MaximumNumberCheck.MaximumNumber("Banana", "Apple", "Peach");
            string TC3 = MaximumNumberCheck.MaximumNumber("Peach", "Banana", "Apple");
            Console.WriteLine("Maximum number in TC1 is: {0}", TC1);
            Console.WriteLine("Maximum number in TC2 is: {0}", TC2);
            Console.WriteLine("Maximum number in TC3 is: {0}", TC3);
        }
    }
}