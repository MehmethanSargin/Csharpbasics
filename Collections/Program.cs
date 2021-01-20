using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> isimler = new List<string> { "Mehmethan", "Kaan", "Emre", "Yunus emre" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[3]);
            isimler.Add("Kader");
            Console.WriteLine(isimler[4]);

        }
    }
}
