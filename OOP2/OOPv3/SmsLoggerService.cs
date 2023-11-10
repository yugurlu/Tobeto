using System;
namespace OOPv3
{
    public class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms sended!");
        }
    }
}

