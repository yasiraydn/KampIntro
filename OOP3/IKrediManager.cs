using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    /// **İnterfaceleri birbirini alternatifi olan ama kod içerikleri farklı olan durumlarda kullanırız.**
    internal interface IKrediManager
    {
        public void Hesapla();
        public void BirseyYap();   
        
    }
}
