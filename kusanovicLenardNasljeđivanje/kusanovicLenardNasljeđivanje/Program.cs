﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardNasljeđivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u1 = new Ucenik();
            u1.Ime = "Marko";
            u1.Prezime = "Marulić";
            u1.Razred = 3;

            Nastavnik n1 = new Nastavnik();
            n1.Ime = "Roki";
            n1.Prezime = "Smailagic";
            n1.Predmet = "Programiranje";

            Console.WriteLine(u1.ToString());
            Console.WriteLine(n1.DohvatiPodatke());

            Console.ReadKey();
        }
        

        
    }
}
