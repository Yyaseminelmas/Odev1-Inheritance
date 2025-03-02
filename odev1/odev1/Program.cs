
using System;
using odev1.classes;



class Program
{
    static void Main()
    {
        // Araba nesnelerini oluşturuyoruz
        Car[] arabalar = {
            new BMW(),
            new Porsche(),
            new Mercedes(),
            new Togg(),
            
        };

      
        foreach (var araba in arabalar)
        {
            araba.VitesTipi();
        }
    }
}
