using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi" + " "+ urun.Adi);
            //yönetim kullanıcılar sepete
            //ürün eklediğinde sepete eklendi yerine
            //tebrikler sepeti eklendi yazmanı istiyorsa bunu tek tek gidip bütün
            //sayfalardan değiştirmek yerine yukarıda yazdığımız
            //metodu değiştirirek yapabiliriz.

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Sepete eklendi" + " " + urunAdi);
        }

    }
}
