using Single_Responsibility.SingleReponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility.SingleResponsibility
{
    class CustomerSearch
    {
        private ICustomerRespository customerRepo;

        public CustomerSearch(ICustomerRespository repo)
        {
            customerRepo = repo;
        }

        public ICustomerRespository SearchById(string searchItem)
        {
            return (ICustomerRespository)customerRepo.Customers.Where(x => x.CustomerId == searchItem);
        }

        public ICustomerRespository SearchByName(string searchItem)
        {
            return (ICustomerRespository)customerRepo.Customers.Where(x => x.CustomerName == searchItem);
        }


    }
}
