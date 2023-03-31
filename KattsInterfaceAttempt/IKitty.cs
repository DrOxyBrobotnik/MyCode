using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KattsInterfaceAttempt
{
    internal interface IKitty
    {
        string KattEnergy { get; set; }
        string KattSleepy { get; set; }
    }
}
