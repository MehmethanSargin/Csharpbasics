using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) {
            Console.WriteLine("Müşteri eklendi  " + customer.Name + " " + customer.Surname);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Güncellendi  " + customer.Name + " " + customer.Surname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi  " + customer.Name + " " + customer.Surname);
        }

        public void List(Customer[] customer) {
            foreach (var customers in customer) {
                Console.WriteLine("ID: " + customers.Id);
                Console.WriteLine("Name: " + customers.Name);
                Console.WriteLine("Surname: " + customers.Surname);
            }
            
            }
        }
    }

