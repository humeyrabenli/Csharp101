using System;

namespace interfaces
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e log yazar");
        }
    }
}