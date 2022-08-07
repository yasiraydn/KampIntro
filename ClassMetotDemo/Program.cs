//Bir bankada müşteri takibi yapmak istiyorsunuz.
//Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
//MusteriManager sınıfı oluşturunuz. 
//Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.





using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Meslegi = "Memur";
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Emin";
            musteri1.TC_Kimlik_No = "14524066870";
            musteri1.AylikGelir = 7500;


            Musteri musteri2 = new Musteri();
            musteri2.Meslegi = "Doktor";
            musteri2.Ad = "Yavuz";
            musteri2.Soyad = "Yaprak";
            musteri2.TC_Kimlik_No = "12512468246";
            musteri2.AylikGelir = 25000;

            Musteri musteri3 = new Musteri();
            musteri3.Meslegi = "Avukat";
            musteri3.Ad = "Duygu";
            musteri3.Soyad = "Gündüz";
            musteri3.TC_Kimlik_No = "21045785220";
            musteri3.AylikGelir = 16000;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 , musteri3};



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteriler);

        }
    
    }
}
