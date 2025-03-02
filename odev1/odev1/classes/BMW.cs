using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1.classes
{
    public class BMW : Car
    {
        // BMW sınıfı, Car sınıfından miras alıyor
        public BMW() : base("BMW") { }

        // Vites tipini özelleştiriyoruz (override ediyoruz)
        public override void VitesTipi()
        {
            Console.WriteLine($"{Marka} → Düz viteslidir.");
        }
    }

}
