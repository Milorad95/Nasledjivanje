using System;

namespace Nasledjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Automobil {
                Boja = "Bela",
                MaxBrzina = 250,
                Proizvodjac = "Audi",
                Model = "Q7",
                SnagaMotora = 220,
                UbrzanjeDoSto = 100
            };
            v.podesiTrenutnuBrzinu(80);
            v.ispis();

            Console.ReadLine();

            Console.WriteLine("Ubrzanje za 25 km/h...");
            Console.WriteLine();
            v.ubrzaj(25);
            v.ispis();

            Console.ReadLine();

            Console.WriteLine("Zaustavljanje vozila...");
            Console.WriteLine();
            Console.WriteLine($"Brzina: {v.zaustavi()} km/h");

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Vrati brzinu vozila...");
            Console.WriteLine();

            Console.WriteLine($"Trenutna brzina vozila: {v.trenutnaBrzina()} km/h");
            Console.WriteLine();

            Console.ReadLine();

            Console.WriteLine("Vozilo svira...");
            v.sviraj();
            Console.WriteLine();

            Console.ReadLine();

            Console.WriteLine("Automobil ubrzava do 100 km/h...");
            v.ubrzanje(100);
            Console.WriteLine($"Trenutna brzina vozila: {v.trenutnaBrzina()} km/h");
            Console.WriteLine();

            Console.ReadLine();

            Console.WriteLine("Avion...");
            Console.WriteLine();

            var a = new Avion
            {
                Boja = "Siva",
                TrenutnaVisina = 2700,
                Kapacitet = 800,
                MaxBrzina = 900,
                Model = "Airbus 720",
                Proizvodjac = "Boing"
            };
            a.podesiTrenutnuBrzinu(420);
            a.ispis();
            Console.WriteLine();

            Console.ReadLine();

            Console.WriteLine("Zaustavljanje vozila i aviona...");
            Console.WriteLine();
            Console.WriteLine($"Brzina automobila i aviona: {v.zaustavi()} km/h\nTrenutna visina aviona: {a.zaustavi()} metara");

            Console.WriteLine();
            Console.WriteLine("Kraj programa...");
            Console.ReadLine();
        }
    }
}
