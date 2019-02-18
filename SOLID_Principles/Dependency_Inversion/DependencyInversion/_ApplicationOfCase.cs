using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.DependencyInversion
{
    class _ApplicationOfCase
    {

        _ApplicationOfCase()
        {
            INotifier notifier = null;

            if ("UserHasEmail" == "UserHasEmail")
            {
                notifier = new EmailNotifier();
            }

            if ("UserHasPhoneNumber" == "UserHasPhoneNumber")
            {
                notifier = new SmsNotifier();
            }

            UserManager manager = new UserManager(notifier);
            manager.ChangePassword("user", "old", "new");
        }
    }
}
