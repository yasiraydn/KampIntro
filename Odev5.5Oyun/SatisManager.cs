using System;
using System.Threading.Channels;

namespace Odev5._5Oyun
{
    public class SatisManager:ISatisService
    {
        public void Sell(Player player, Oyun oyun)
        {
            Console.WriteLine("Oyun satildi.");
        }

        public void Sell(Player player, Oyun oyun, Kampanya kampanya)
        {
            Console.WriteLine(oyun.OyunAdi + " : " + "Kampanyalayla satildi.");
        }
    }
}