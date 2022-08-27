
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;
using MernisServiceReference;


namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
           
                KPSPublicSoapClient client = new KPSPublicSoapClient();
            // return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth);
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId,
                                                 customer.FirstName,
                                                 customer.LastName,
                                                 customer.DateOfBirth);
           
        }
    }
}
