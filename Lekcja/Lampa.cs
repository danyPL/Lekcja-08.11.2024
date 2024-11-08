using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja
{
    public class Lampa
    {
        public bool Stan { get; set; }
        public int Intesivity { get; set; }
        public Zarowka Zarowka {get ;set;}
        public Lampa(Zarowka zarowka) {
            Zarowka = zarowka;
            Stan = false;
            Intesivity = 0;
        }
        public bool TogglePower()
        {
            Stan = !Stan;
            Zarowka.swieci = !Zarowka.swieci;
            return Stan;
        }
        public bool CheckLight()
        {
            return Stan;
        }
        public bool CheckBurned()
        {
            return Zarowka.CheckBurned();
        }
        public void Rozjasnij(int intesiv)
        {
        if(intesiv <= 10)
            {
                Intesivity = intesiv;
            }
        }
        public bool WymienZarowke()
        {
            if(Stan == false)
            {
                Zarowka = new();
                return true;
            }
            return false;
        }
      
    }
}
