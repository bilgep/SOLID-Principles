using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.AntiInterfaceSegregation
{
    class OnlineOrderProcess : IOrderProcess
    {
        public void ProcessOrder(string order)
        {
            // APPLICABLE
        }

        public bool ValidateCardInfo(string cardInfo)
        {
            // APPLICABLE
            return true;
        }

        public bool ValidateShippingAddress(string address)
        {
            // APPLICABLE
            return true;
        }
    }
}
