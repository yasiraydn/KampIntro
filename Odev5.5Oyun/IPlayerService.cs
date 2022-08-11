using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5._5Oyun
{
    internal interface IPlayerService
    {
        void Add(Player player); 
        void Remove(Player player); 
        void Update(Player player);


    }
}
