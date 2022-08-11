using System;
using System.Xml;

namespace Odev5._5Oyun
{
    public class PlayerManager:IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine("Oyuncu Eklendi" + player.Ad);
        }

        public void Remove(Player player)
        {
            Console.WriteLine("Oyuncu Silindi" + player.Ad);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu Güncellendi" + player.Ad);
        }
    }
}