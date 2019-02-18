using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.LiskovSubstitution
{
    class UserSetting : IWriteableSetting, IReadableSetting
    {
        public IReadableSetting GetSetting()
        {
            IReadableSetting setting = null;
            return setting;
        }

        public void SetSetting(string settingName, string settingValue)
        {
            IWriteableSetting newSetting = null;
            // Set settings based on given parameters
        }
    }
}
