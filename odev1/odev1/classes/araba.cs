using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;  

namespace odev1.classes
{
    //  Üst Sınıf
    public class Car
    {
        // Ortak özellikler
        public string Marka { get; set; }

        
        public Car(string marka)
        {
            Marka = marka;
        }

       
        public virtual void VitesTipi()
        {
            Console.WriteLine($"{Marka} → Vites tipi belirtilmemiş.");
        }
    }
}
