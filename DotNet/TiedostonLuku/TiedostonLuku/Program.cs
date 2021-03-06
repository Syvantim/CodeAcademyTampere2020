﻿using System;
using System.IO;

namespace TiedostonLuku
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Tiedostosumman laskenta alkaa.");

      string tiedostoNimi = @"C:\Academy\Tampere\Git\DotNet\TiedostonLuku\Luvut.txt";
 
      string[] rivit = File.ReadAllLines(tiedostoNimi);

      int summa = 0;
      foreach (string rivi in rivit)
      {
        int luku = int.Parse(rivi);
        summa += luku;
      }
      Console.WriteLine($"Tiedostojen lukujen summa on: {summa}.");
      Console.WriteLine(summa);
    }
  }
}
