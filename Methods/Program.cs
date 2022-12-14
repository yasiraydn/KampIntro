using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 35;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";
            urun2.StokAdedi = 70;


            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("---------");
            }

            Console.WriteLine("------------Metotlar------");
            /// encapsulation yaptık 
            /// yani bizden yeni bir bilgi girilmesi daha istendiğinde class a yazdığımız için
            /// sayfalar patlamadı
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            /// ama aşağıda patlardı çünkü class ta yapmadık 
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8); 


        }
    }
}



//metotlar tekrar tekrar kullanabilirliği sağlayan kod bloklarıdır.
// dont repeat yourself !!!!! - clean code - best practice  