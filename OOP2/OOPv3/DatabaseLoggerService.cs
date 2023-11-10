using System;
namespace OOPv3
{
    public class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged in Database!");
        }
    }
}

