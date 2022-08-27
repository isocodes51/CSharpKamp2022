using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // BaseCustomerManager customerManager = new NeroCustomerManager() ;
            BaseCustomerManager customerManager = new StarBucksCustomerManager(new MernisServiceAdapter()) ;
            customerManager.Save(new Customer { DateOfBirth = 198, FirstName = "İsmail", LastName = "Çiçek", NationalityId = 17833709390, Id = 1 });

        }
    }
}
