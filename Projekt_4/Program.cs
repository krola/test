using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_4
{
  class Program
  {
    static void Main(string[] args)
    {
      var imie = Console.ReadLine();
      var osoba1 = new Human("Ola", 30, 1.52, 55, true);
      var osoba2 = new Human("Marek", 35, 1.70, 75, false);
      var osoba3 = new Human();
      var osoba4 = new Human(imie, 25, 1.6, 80, true);
      osoba1.Imie = "Marzena";
      osoba1.wiek = 40;   
      int i;
      Human h = osoba1;
    }
  }
}
