using System;

namespace interfaces
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("dosyaya log yazar");
        }
    }
}