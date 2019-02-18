using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.AntiDependecyInversion
{
    class UserManager
    {
        public void ChangePassword(string userName, string oldPassword, string newPassword)
        {
            // TODO: Change password operations

            EmailNotifier notifier = new EmailNotifier();
            notifier.Notify("Password has changed");
        }
    }
}
