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
      //Zadanie 2 - liczenie z funkcja "if"
      Console.WriteLine("Podaj liczbe pierwsza");
      var C = Console.ReadLine();
      Console.WriteLine("Podaj liczbe druga");
      var D = Console.ReadLine();
      Console.WriteLine("Podaj dzialanie");
      var dzialanie = Console.ReadLine();

      var c = Convert.ToDouble(C);
      var d = Convert.ToDouble(D);

      if (dzialanie == "+")
      {
        Console.WriteLine(c + d);
      }
      if (dzialanie == "-")
      {
        Console.WriteLine(c - d);
      }
      if (dzialanie == "*")
      {
        Console.WriteLine(c * d);
      }

      //Zadanie 3 - metoda, która jako argument przyjmuje liczbę i zwraca true jeśli liczba jest parzysta
      Console.WriteLine("Podaj dowolna liczbe, dla której sprawdzimy parzystość");
      var Liczba = Console.ReadLine();
      var liczba = Convert.ToInt32(Liczba);

      if (liczba % 2 == 0)
      {
        Console.WriteLine("True");
      }
      else
      {
        Console.WriteLine("False");
      }
      Console.ReadLine();
    }
  }
}
