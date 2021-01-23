using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Transport Credit Calculate");
        }

        public void Do()
        {
            throw new NotImplementedException();
        }
    }
}
