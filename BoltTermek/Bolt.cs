using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltTermek
{
    internal class Bolt
    {
        private string nev;
        private List<Termek> termekek;

        public Bolt(){
            this.nev = "JoBolt";
            this.termekek = new List<Termek>();
        }


        public void termekHozzaadas(Termek termek)
        {
            this.termekek.Add(termek);
        }

        public Termek termekKereses(string termekNeve)
        {
            foreach (Termek item in termekek)
            {
                if(item.Nev == termekNeve)
                {
                    return item;
                }

            }
            return null;
            
        }

        public bool termekTorles(string termekNeve)
        {
            foreach (Termek item in termekek)
            {
                if (item.Nev == termekNeve)
                {
                    termekek.Remove(item);
                    return true;
                }

            }
            return false;
        }


        public override string ToString()
        {
            string termek = "";
            foreach (Termek item in termekek)
            {
                termek += item.ToString() + " ";
            }

            return $"{this.nev} {termek}";
        }

    }
}
