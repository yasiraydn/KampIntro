using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Yasir";
            int yas = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursunEgitmeni = "Murat";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni + " " + kurs1.IzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.KursunEgitmeni + " " + kurs2.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursunEgitmeni + " " + kurs.IzlenmeOrani);
                Console.WriteLine("---------------");

            }
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string KursunEgitmeni { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}