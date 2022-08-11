using System;

namespace Odev5._5Oyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player()
            {
                Ad = "Mustafa", 
                Soyad = "Kurt",
                TcNO = "1111111111", 
                DogumYılı = new DateTime(2001,1,1)
            };

            Oyun oyun1 = new Oyun()
            {
                OyunAdi = "Rainbow Six Seige",
                OyunFiyati = 89,
                OyunSirketi = "Bugisoft"
            };
            Kampanya kampanya = new Kampanya()
            {
                Id = 69,
                Adi = "Poserlara özel kampanya",
                IndirimOrani = 31,



            };


            PlayerManager playerManager = new PlayerManager();
            //playerManager.Add(player1);
            KampanyaManager kampanyaManager = new KampanyaManager();
            SatisManager satisManager = new SatisManager();
            satisManager.Sell(player1, oyun1, kampanya);






        }
    }
}
