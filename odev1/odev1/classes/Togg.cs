using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1.classes
{
    public class Togg : Car
    {
        public Togg() : base("Togg") { }

        public override void VitesTipi()
        {
            Console.WriteLine($"{Marka} → Otomatik viteslidir.");
        }
    }

}
