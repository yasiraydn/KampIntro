using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklendi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silindi : " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Degistir(Musteri musteri)
        {
            Console.WriteLine("Degistirildi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Listele(Musteri[] musteriler) {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.AylikGelir);
                Console.WriteLine(musteri.TC_Kimlik_No);
                Console.WriteLine("-----------------------");
                
            }
        }
    }
}
