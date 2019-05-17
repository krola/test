using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Podaj liczbe pierwsza");
      var A = Console.ReadLine();
      Console.WriteLine("Podaj liczbe druga");
      var B = Console.ReadLine();

      var a = Convert.ToDouble(A);
      var b = Convert.ToDouble(B);

      double dodaj = Suma(a, b);
      double odejmij = Roznica(a, b);
      double pomnoz = Iloczyn(a, b);

      Console.WriteLine("Suma");
      Console.WriteLine(dodaj);
      Console.WriteLine("Roznica");
      Console.WriteLine(odejmij);
      Console.WriteLine("Iloczyn");
      Console.WriteLine(pomnoz);
      Console.ReadLine();
    }
    static double Suma(double a, double b)
    {
      return a + b;
    }
    static double Roznica(double a, double b)
    {
      return a - b;
    }
    static double Iloczyn(double a, double b)
    {
      return a * b;
    }
  }
}
