using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Podaj liczbe pierwsza");
      var C = Console.ReadLine();
      Console.WriteLine("Podaj liczbe druga");
      var D = Console.ReadLine();
      Console.WriteLine("Podaj dzialanie");
      var dzialanie = Console.ReadLine();

      var c = Convert.ToDouble(C);
      var d = Convert.ToDouble(D);

      double wynik;

      if (dzialanie == "+")
      {
        wynik = c + d;
        Console.WriteLine(c + d);
      }
      if (dzialanie == "-")
      {
        wynik = c - d;
        Console.WriteLine(c - d);
      }
      if (dzialanie == "*")
      {
        wynik = c * d;
        Console.WriteLine(c * d);
      }
      Console.ReadLine();
    }
  }
}
