using System;

namespace Odev5._5Oyun
{
    public class KampanyaManager:IKampanyaService
    {
        public void Add(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Eklendi.");
        }

        public void Remove(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public void Update(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}