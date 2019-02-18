using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.AntiInterfaceSegregation
{
    class CashOnDeliveryOrderProcess : IOrderProcess
    {
        public void ProcessOrder(string order)
        {
            // APPLICABLE
        }

        public bool ValidateCardInfo(string cardInfo)
        {
            // NOT APPLICABLE
            throw new NotImplementedException();
        }

        public bool ValidateShippingAddress(string address)
        {
            // APPLICABLE
            return true;
        }
    }
}
