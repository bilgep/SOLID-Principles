using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.AntiLiskovSubstitution
{
    class GuestSetting : ISetting
    {
        public ISetting GetSetting()
        {
            ISetting setting = null;
            return setting;
        }

        public void SetSetting(string settingName, string settingValue)
        {
            // CAN NOT APPLICABLE
            throw new NotImplementedException();
        }
    }
}
