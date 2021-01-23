using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HouseCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("House Credit Calculate");
        }

        public void Do()
        {
            throw new NotImplementedException();
        }
    }
}
