using CoffeeShop.Abstract;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;
using System;

namespace CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1986, 8, 1), FirstName = "Engin", LastName = "Demirog", NationalityId = "**********" });
            Console.ReadLine();
        }

    }

}
