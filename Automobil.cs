using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje
{
    class Automobil : Vozilo
    {
        public int SnagaMotora { get; set; }
        public int UbrzanjeDoSto { get; set; }

        // automobil svira
        public void sviraj()
        {
            Console.Beep();
        }

        // ispis automobila u konzoli
        public void ispis()
        {
            Console.WriteLine($"Boja: {this.Boja}\nTrenutna brzina: {this.trenutnaBrzina()} km/h\nMaksimalna brzina: {this.MaxBrzina} km/h\nProizvodjac: {this.Proizvodjac}\nModel: {this.Model}\nSnaga motora: {this.SnagaMotora} ks");
        }

        // ubrzaj onoliko kolika je vrednost parametra brzina
        public void ubrzanje(int brzina)
        {
            this.UbrzanjeDoSto = brzina;
            this.podesiTrenutnuBrzinu(UbrzanjeDoSto);
        }
    }
}
