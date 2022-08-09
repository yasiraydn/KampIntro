using System;

namespace OOP3
{
    internal class FileLoggerService : ILoogerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
