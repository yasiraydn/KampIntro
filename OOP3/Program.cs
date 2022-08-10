using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();  
            //ILoogerService databaseLoggerService = new DatabaseLoggerService(); aşağıdaki gibi paranteze de atabiliriz bunu
            //ILoogerService filebaseLoggerService = new FileLoggerService(); 
            
            
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,esnafKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
