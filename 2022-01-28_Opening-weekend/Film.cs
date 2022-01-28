using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_01_28_Opening_weekend
{
    class Film
    {
        public string eredetiCim { get; set; }
        public string magyarCim { get; set; }
        public string Bemutato { get; set; }
        public string Forgalmazo { get; set; }
        public int Bevetel { get; set; }
        public int Latogatok { get; set; }

        public Film(string sor)
        {
            string[] t = sor.Split(';');
            eredetiCim = t[0];
            magyarCim = t[1];
            Bemutato = t[2];
            Forgalmazo = t[3];
            Bevetel = int.Parse(t[4]);
            Latogatok = int.Parse(t[5]);
        }
    }
}
