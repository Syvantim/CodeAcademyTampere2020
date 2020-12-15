using System;

namespace RandomValue
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = new System.Random();
            int rInt = r.Next(1, 20);
            int laskuri = 0;
            int arvattu = 0;

            do
            {
                Console.Write("Arvaa luku");
                arvattu = int.Parse(Console.ReadLine());
                laskuri++;
            } while (arvattu != rInt
                     && laskuri < 3);



        }
    }
}
