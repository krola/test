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
      string name = Name();
      string age = Age();
      Console.WriteLine(name);
      Console.WriteLine(age);
    }
     
    static string Name()
    {
      return "Paulina";
    }
    static string Age()
    {
      return "29";
    }
  }

}
