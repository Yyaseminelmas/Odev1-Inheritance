using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1.classes
{
    public class Mercedes : Car
    {
        public Mercedes() : base("Mercedes") { }

        public override void VitesTipi()
        {
            Console.WriteLine($"{Marka} → Otomatik viteslidir.");
        }
    }

}
