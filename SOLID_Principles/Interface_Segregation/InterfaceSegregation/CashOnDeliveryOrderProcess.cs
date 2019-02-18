using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.InterfaceSegregation
{
    class CashOnDeliveryOrderProcess : IOrderProcess
    {
        public void ProcessOder()
        {
            // APPLICABLE
        }

        public bool ValidateShippingAddress()
        {
            // APPLICABLE
            return true;
        }
    }
}
