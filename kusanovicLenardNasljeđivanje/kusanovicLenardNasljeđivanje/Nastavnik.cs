﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardNasljeđivanje
{
    class Nastavnik : Osoba
    {
        string predmet;

        public string Predmet { get => predmet; set => predmet = value; }
    }
}
