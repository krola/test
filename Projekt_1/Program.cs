using System;

namespace Projekt_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string koniec;

            do
            {
                Console.WriteLine("Wpisz liczbę pierwsza");
                var pierwsza = Console.ReadLine();
                Console.WriteLine("Wpisz liczbe druga");
                var druga = Console.ReadLine();
                Console.WriteLine("Podaj działanie ( +, -, /, * )");
                var dzialanie = Console.ReadLine();

                var pierwszaLiczba = Convert.ToDouble(pierwsza);
                var drugaLiczba = Convert.ToDouble(druga);

                var wynik = Double.NaN;

                switch (dzialanie)
                {
                    case "+":
                        wynik = Dodaj(pierwszaLiczba, drugaLiczba);
                        break;
                    case "-":
                        wynik = Odejmij(pierwszaLiczba, drugaLiczba);
                        break;
                    case "*":
                        wynik = Pomnoz(pierwszaLiczba, drugaLiczba);
                        break;
                    case "/":
                        wynik = Podziel(pierwszaLiczba, drugaLiczba);
                        break;
                    default:
                        Console.WriteLine("Bledne dzialanie");
                        break;
                }

                Console.WriteLine(wynik);
                Console.WriteLine("Koniec? Wpisz t");
                koniec = Console.ReadLine();
            }
            while (koniec != "t");
        }

        private static double Dodaj(double pierwsza, double druga)
        {
            return pierwsza + druga;
        }

        private static double Odejmij(double pierwsza, double druga)
        {
            return pierwsza - druga;
        }

        private static double Pomnoz(double pierwsza, double druga)
        {
            return pierwsza * druga;
        }

        private static double Podziel(double pierwsza, double druga)
        {
            if (druga == 0)
            {
                throw new Exception("Nie dzieli się przez 0"); // wyjatek - czyli nieprzewidziane zachowanie - powoduje ze program się wysypie
            }
            return pierwsza / druga;
        }
    }
}