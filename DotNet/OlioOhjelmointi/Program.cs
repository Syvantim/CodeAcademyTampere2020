using System;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Auto oma = new Auto()
            {
                Väri = "punainen",
                Huippunopeus = 210
            };

            oma.Käynnistä();
            oma.Kiihdytä();

            Auto naapurin = new Auto()
            {
                Väri = "sininen",
                Huippunopeus = 200
            };

            Urheiluauto avo = new Urheiluauto() {
                KattoAlhaalla = true
            };

        }
    }
}
