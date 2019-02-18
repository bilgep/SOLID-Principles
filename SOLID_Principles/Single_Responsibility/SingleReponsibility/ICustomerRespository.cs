using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility.SingleReponsibility
{
    interface ICustomerRespository
    {
        IQueryable<Customer> Customers { get; set; }
    }
}
