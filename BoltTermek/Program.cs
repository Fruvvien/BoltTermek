using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltTermek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bolt bolt = new Bolt();
            Termek termek = new Termek();
            bolt.termekHozzaadas(termek);
            termek.mennyisegNoveles(1);
            termek.mennyisegCsokkentese(1);
            // termek.mennyisegCsokkentese(1); 0 alá esés lekezelésének tesztelés
             

            

            Console.WriteLine(bolt.ToString());

            Console.WriteLine(bolt.termekKereses("Alma"));             
            if (bolt.termekTorles("Alma"))
            {
                Console.WriteLine("Sikeres törlés");
            }
            else
            {
                Console.WriteLine("Nem sikerült törölni");
            };


        }
    }
}
