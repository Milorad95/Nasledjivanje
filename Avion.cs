using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje
{
    class Avion : Vozilo
    {
        public int TrenutnaVisina { get; set; }
        public int Kapacitet { get; set; }

        // zaustavi avion i automobil, metoda iz klase Vozilo
        public override int zaustavi()
        {
            this.TrenutnaVisina = 0;
            return base.zaustavi();
        }


        // ispisi u konzoli sve atribute
        public void ispis()
        {
            Console.WriteLine($"Boja: {this.Boja}\nTrenutna brzina: {this.trenutnaBrzina()} km/h\nMaksimalna brzina: {this.MaxBrzina} km/h\nTrenutna visina: {this.TrenutnaVisina} metara\nKapacitet putnika: {this.Kapacitet}\nProizvodjac: {this.Proizvodjac}\nModel: {this.Model}");
        }
    }
}
