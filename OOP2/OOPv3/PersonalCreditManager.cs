using System;
namespace OOPv3
{
    public class PersonalCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal credit calculated");
        }
    }
}

