using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;


namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
