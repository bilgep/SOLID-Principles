using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.DependencyInversion
{
    interface INotifier
    {
        void Notify(string message);
    }
}
