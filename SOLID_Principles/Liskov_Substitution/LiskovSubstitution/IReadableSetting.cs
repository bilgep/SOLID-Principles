using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.LiskovSubstitution
{
    interface IReadableSetting
    {
        IReadableSetting GetSetting();
    }
}
