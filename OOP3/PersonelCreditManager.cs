using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonelCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personel Credit Calculate");
        }

        public void Do()
        {
            throw new NotImplementedException();
        }
    }
}
