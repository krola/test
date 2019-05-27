using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_5
{
  class Auto
  {
    Marka _marka;
    string _model;
    int _rok;
    float _cena;

    public Auto(Marka marka, string model, int rok, float cena)
    {
      _marka = marka;
      _model = model;
      _rok = rok;
      _cena = cena;
    }
    public Auto()
    {

    }
    public Marka Marka
    {
      get
      {
        return _marka;
      }
      set
      {
        _marka = value;
      }
    }
    public string Model
    {
      get
      {
        return _model;
      }
      set
      {
        _model = value;
      }
    }
    public int Rok
    {
      get
      {
        return _rok;
      }
      set
      {
        _rok = value;
      }
    }
    public float Cena
    {
      get
      {
        return _cena;
      }
      set
      {
        _cena = value;
      }
    }
    public void zmienCene(float nowaCena)
    {
      _cena = nowaCena;
    }
  }
}
