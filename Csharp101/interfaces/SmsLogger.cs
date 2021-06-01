using System;

namespace interfaces
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("sms olarak log yazar");
            
        }
    }
}