using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltTermek
{
    internal class Termek
    {

        private string nev;
        private int ar;
        private int mennyiseg;

        public Termek()
        {
            this.nev = "Alma";
            this.Ar = 200;
            this.mennyiseg = 0;

        }

        public string Nev { get => nev; }
        public int Ar { get => ar; set => ar = value; }
        public int Mennyiseg { get => mennyiseg;}


        public void mennyisegNoveles(int szam)
        {
            this.mennyiseg += szam;

        }

        public void mennyisegCsokkentese(int szam) 
        {
            if(this.mennyiseg > 0)
            {
                this.mennyiseg -= szam;
            }
            else
            {
                Console.WriteLine("Nem lehet tovább csökkenteni");
            }
            
        }

        public override string ToString()
        {
            return $"Név:{this.Nev} Ár:{this.Ar} Mennyiség:{this.Mennyiseg}";
        }
    }
}
