﻿using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
             throw new NotImplementedException();
           
          //  return true;
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
