using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    class Auto
    {
        private string szin;
        private string tipus;
        private double uzemAnyag;
        private double fogyaszt;
        private double km;
        private double megtehetoKm;

        public Auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemAnyag = 0;
            this.km = 0;
        }

        private void MegtehetoKm()
        {
            megtehetoKm = uzemAnyag / fogyaszt * 100;
        }

        public void Tankol(double mennyit)
        {
            uzemAnyag += mennyit;
            MegtehetoKm();
        }

        public void Megy(double km)
        {
            double fogy = fogyaszt / 100 * km;
            this.km += km;

            this.uzemAnyag = uzemAnyag - fogy;
            MegtehetoKm();
        }
        public void Allapot()
        {
            Console.WriteLine("******************************");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km}");
            Console.WriteLine($"Üzemanyag: {uzemAnyag} l");
            Console.WriteLine($"Megtehető km {megtehetoKm} km");
            Console.WriteLine("--------------------------");
        }
    }
}
