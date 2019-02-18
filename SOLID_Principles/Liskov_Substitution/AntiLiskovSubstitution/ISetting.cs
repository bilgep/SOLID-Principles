using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.AntiLiskovSubstitution
{
    interface ISetting
    {
        void SetSetting(string settingName, string settingValue);
        ISetting GetSetting();

    }
}
