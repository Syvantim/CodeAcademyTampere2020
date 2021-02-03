using System;
using System.Net.Http;
namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      string kaupunki = "Tampere";
      Console.WriteLine($"Aloitetaan säätietojen haku kaupungista {kaupunki}.");

      HttpClient client = new HttpClient();
      string url  = $"http://api.openweathermap.org/data/2.5/weather?q={kaupunki}&appid="

     HttpResponseMessage 


    }
  }
}
