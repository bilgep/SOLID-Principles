using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility.AntiSingleResponsibility
{
    class CustomerOperations
    {
        private ICustomerRespository customerRepo;

        public CustomerOperations(ICustomerRespository repo)
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

        public void ExportToCsv()
        {
            // TODO: Export operations
        }

        public void ExportToPdf()
        {
            // TODO: Export operations
        }
    }
}
