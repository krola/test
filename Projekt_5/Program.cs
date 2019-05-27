using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_5
{
  class Program
  {
    static void Main(string[] args)
    {
      var marka1 = new Marka("Kia");
      var auto1 = new Auto(marka1, "AA", 1999, 25000);
      auto1.zmienCene(20000);
      auto1.Cena = 19000;
    }
  }
}
