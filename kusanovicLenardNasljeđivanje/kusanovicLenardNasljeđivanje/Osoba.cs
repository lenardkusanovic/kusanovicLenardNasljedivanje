using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardNasljeđivanje
{
    class Osoba
    {
        string ime;
        string prezime;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public override string ToString()
        {
            string ispis="Ime: " +this.ime +"\nPrezime: " + this.prezime;
            return ispis;
        }
        public string DohvatiPodatke()
        {
            string ispis = "\n Ime: " + this.ime +"\n Prezime: " + this.prezime;
            return ispis;
        }
    }
}
