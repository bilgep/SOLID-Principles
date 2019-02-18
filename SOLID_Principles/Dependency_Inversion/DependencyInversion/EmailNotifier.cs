using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.DependencyInversion
{
    class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            // Send Email message
            throw new NotImplementedException();
        }
    }
}
