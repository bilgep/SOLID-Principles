using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.DependencyInversion
{
    class SmsNotifier : INotifier
    {
        public void Notify(string message)
        {
            // Send SMS message
            throw new NotImplementedException();
        }
    }
}
