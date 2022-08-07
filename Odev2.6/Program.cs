using System;

namespace Odev2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            
            Klavye klavye1 = new Klavye();
            klavye1.KlavyeAdi = "Razer Blackwidow V3";
            klavye1.KlavyeTuru = "Mekanik";
            klavye1.SwitchTuru = "Green";
            klavye1.Fiyati = 2000;


            Klavye klavye2 = new Klavye();
            klavye2.KlavyeAdi = "Corsair K70 RGB MK2";
            klavye2.KlavyeTuru = "Mekanik";
            klavye2.SwitchTuru = "Red";
            klavye2.Fiyati = 2400;

            Klavye klavye3 = new Klavye();
            klavye3.KlavyeAdi = "Steelseries Apex 5 Hybrid";
            klavye3.KlavyeTuru = "Mekanik";
            klavye3.SwitchTuru = "Hybrid";
            klavye3.Fiyati = 2199;

            Klavye klavye4 = new Klavye();
            klavye4.KlavyeAdi = "Logitech G213 Prodigy";
            klavye4.KlavyeTuru = "Membran";
            klavye4.SwitchTuru = "Plastik Membran";
            klavye4.Fiyati = 595;

            Klavye[] klavyeler = new Klavye[] { klavye1, klavye2, klavye3, klavye4 };

            foreach (var klavye in klavyeler)
            {
                Console.WriteLine("Klavye Adi:" + klavye.KlavyeAdi);
                Console.WriteLine("Klavye Turu:" + klavye.KlavyeTuru);
                Console.WriteLine("Switch Turu:" + klavye.SwitchTuru);
                Console.WriteLine("Fiyati:" + klavye.Fiyati);
                Console.WriteLine("*********");
            }
            for (int i = 0; i < klavyeler.Length; i++)
            {
                Console.WriteLine("Klavye Adi:" + klavyeler[i].KlavyeAdi);
                Console.WriteLine("Klavye Turu:" + klavyeler[i].KlavyeTuru);
                Console.WriteLine("Switch Turu:" + klavyeler[i].SwitchTuru);
                Console.WriteLine("Fiyati:" + klavyeler[i].Fiyati);
                Console.WriteLine("----------");
            }
            int j = 0;
            while (j < klavyeler.Length)
            {
                Console.WriteLine("Klavye Adi:" + klavyeler[j].KlavyeAdi);
                Console.WriteLine("Klavye Turu:" + klavyeler[j].KlavyeTuru);
                Console.WriteLine("Switch Turu:" + klavyeler[j].SwitchTuru);
                Console.WriteLine("Fiyati:" + klavyeler[j].Fiyati);
                Console.WriteLine("///////////");
                j++;
            }


        }
        class Klavye
        {
            public string KlavyeAdi { get; set; }
            public string KlavyeTuru { get; set; }
            public string SwitchTuru { get; set; }
            public int Fiyati { get; set; }
        }
    }
}
