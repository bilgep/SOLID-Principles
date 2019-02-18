using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.LiskovSubstitution
{
    class GuestSetting : IReadableSetting
    {
        public IReadableSetting GetSetting()
        {
            IReadableSetting setting = null;
            return setting;
        }

        // NO WRITE SETTING OPERATION
    }
}
