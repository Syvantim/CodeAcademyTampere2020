using System;

namespace OlioOhjelmointi
{
    public class Auto
    {
        public string Merkki { get; set; }

        public string Malli { get; set; }

        public int Huippunopeus { get; set; }

        public string Väri { get; set; }

        public int Nopeus { get; set; }

        public bool MoottoriKäynnissä { get; set; }

        public void Käynnistä()
        {
          MoottoriKäynnissä = true;
          Console.WriteLine($"Auto {Merkki} {Malli} on käynnissä." );
        }

        public void Sammuta()
        {
            MoottoriKäynnissä = false;
            Nopeus=0;
        }

        public void Kiihdytä()
        {
            if(Nopeus < Huippunopeus)
            {Nopeus += 5;}
            
            
        }

        public void Jarruta()
        {
            

            if (Nopeus>0)
            {
                Nopeus -= 5;
            }

            if (Nopeus<0)
            {
                Nopeus = 0;
            }
        }
    }
}