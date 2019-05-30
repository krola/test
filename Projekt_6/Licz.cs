using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_6
{
  class Licz
  {
    public int wartosc = 5;

    public Licz(int a)  //konstruktor
    {
      wartosc = a;
    }
    public int Dodaj(int a)
    {
      return wartosc + a;
    }
    public int Odejmij(int a)
    {
      return wartosc - a;
    }
  }
}
