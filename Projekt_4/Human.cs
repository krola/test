using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_4
{
  class Human
  {
    string imie;
    public int wiek;
    double wzrost;
    double _waga;
    bool _plec;

    public Human(string imie, int wiek, double wzrost, double waga, bool plec)
    {
      this.imie = imie;
      this.wiek = wiek;
      this.wzrost = wzrost;
      _waga = waga;
      _plec = plec;
    }
    public Human()
    {
      imie = "Ala";
    }
    public string Imie
    {
      get
      {
        return imie;
      }
      set
      {
        imie = value;
      }
    }
    public void zmienImie(string noweImie)
    {
      imie = noweImie;
    }
  }
}
