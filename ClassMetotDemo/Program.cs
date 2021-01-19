using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Mehmethan";
            customer1.Surname = "Sargın";
            
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Engin";
            customer2.Surname = "Demiroğ";

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Müşteri Listesi ");
            customerManager.List(customers);
            Console.WriteLine("-------------------------------");
            customerManager.Update(customer2);
            Console.WriteLine("-------------------------------");
            customerManager.Delete(customer1);
            

        }
    }
}
