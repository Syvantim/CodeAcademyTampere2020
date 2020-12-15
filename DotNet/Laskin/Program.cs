using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku1: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku2: ");
            int luku2 = int.Parse(Console.ReadLine());
            int summa = luku1 + luku2;
            Console.WriteLine("{0} + {1} = {2}", luku1, luku2, summa);


        }
    }
}
