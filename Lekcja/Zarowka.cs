using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja
{
    public class Zarowka
    {
        public bool swieci {  get; set; }
        public bool spalona { get; set; }
        public Zarowka() {
            swieci = false;
            spalona = false;
        }
        public bool ToggleLight()
        {
            swieci = !swieci;
            return swieci;
        }

        public bool CheckLight()
        {
            return swieci;
        }
        public bool CheckBurned()
        {
            return spalona;
        }
    }
}
