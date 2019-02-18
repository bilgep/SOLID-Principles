using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.InterfaceSegregation
{
    class OnlineOrderProcess : IOrderProcess, IOnlineOrderProcess
    {
        public void ProcessOder()
        {
            // APPLICABLE
        }

        public bool ValidateCardInfo()
        {
            // APPLICABLE
            return true;
        }

        public bool ValidateShippingAddress()
        {
            // APPLICABLE
            return true;
        }
    }
}
