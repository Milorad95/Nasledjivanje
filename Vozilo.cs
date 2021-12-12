using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje
{
    class Vozilo
    {
        public string Boja { get; set; }
        private int TrenutnaBrzina { get; set; }
        public int MaxBrzina { get; set; }
        public string Proizvodjac { get; set; }
        public string Model { get; set; }

        // ubrzaj onoliko kolika je vrednost parametra brzina
        public void ubrzaj(int brzina)
        {
            this.TrenutnaBrzina += brzina;
            this.trenutnaBrzina();
        }

        // zaustavi vozilo
        public virtual int zaustavi()
        {
            return this.TrenutnaBrzina = 0;
        }

        // vrati trenutnu brzinu
        public int trenutnaBrzina()
        {
            return this.TrenutnaBrzina;
        }

        // podesi trenutnu brzinu
        public void podesiTrenutnuBrzinu(int brzina)
        {
            this.TrenutnaBrzina = brzina;
        }
    }
}
