using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.DependencyInversion
{
    class UserManager
    {
        private INotifier notifier;

        public UserManager(INotifier ntfr)
        {
            this.notifier = ntfr;
        }

        public void ChangePassword(string userName, string oldPassword, string newPassword)
        {
            // TODO: Password change operations

            notifier.Notify("Password has changed");
        }
    }
}
