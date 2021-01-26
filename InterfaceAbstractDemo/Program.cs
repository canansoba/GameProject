using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrate;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1992,12,2), FirstName = "Canan", LastName = "Soba", NationalityId="12354786254"});
            Console.ReadLine();
            
        }
    } 
}
