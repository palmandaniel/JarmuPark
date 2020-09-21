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
            lada.Allapot();

            Console.Write("Mennyit megy a Trabant? (km) ");
            double km2 = double.Parse(Console.ReadLine());
            trabant.Megy(km2);
            trabant.Allapot();

            Console.ReadKey();
        }
    }
}
