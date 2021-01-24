﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            // Kullanıcı kendi Tc bilgilerini girer.
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1996, 1, 1),
                FirstName = "", 
                LastName = "",
                NationalityId = "" 
            });

            Console.ReadLine();
        }
    }
}
