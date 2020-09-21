using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto lada = new Auto("piros", "Lada2112", 11);
            Auto trabant = new Auto("zöld", "Trabant 1.1", 8);

            lada.Tankol(20);
            trabant.Tankol(20);

            lada.Allapot();
            trabant.Allapot();

            Console.Write("Mennyit megy a Lada? (km) ");
            double km1 = double.Parse(Console.ReadLine());
            lada.Megy(km1);
            Console.WriteLine("Utazás után");
            Console.WriteLine();
            Console.WriteLine("Lada kmóra állása: {0}", lada.KM);
            Console.WriteLine("Lada megtehető km: {0}", lada.MEGTEHETOKM);
            Console.WriteLine("Lada üzemanyag a tartályban (l) {0}",lada.UZEMANYAG);
            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.Write("Mennyit megy a Trabant? (km) ");
            double km2 = double.Parse(Console.ReadLine());
            trabant.Megy(km2);
            Console.WriteLine("Utazás után");
            Console.WriteLine();
            Console.WriteLine("Trabant kmóra állása: {0}", trabant.KM);
            Console.WriteLine("Trabant megtehető km: {0}", trabant.MEGTEHETOKM);
            Console.WriteLine("Trabant üzemanyag a tartályban (l) {0}", trabant.UZEMANYAG);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
