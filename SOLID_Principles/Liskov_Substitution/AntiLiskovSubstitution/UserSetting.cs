using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.AntiLiskovSubstitution
{
    class UserSetting : ISetting
    {

        public ISetting GetSetting()
        {
            ISetting setting = null;
            return setting;
        }

        public void SetSetting(string settingName, string settingValue)
        {
            ISetting newSetting = null;
            // Set settings based on given parameters
        }
    }
}
