using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarRealmsTracker
{
    /// <summary>
    /// The enumeration of possible modifiers.
    /// </summary>
    [Flags]
    public enum ModiferKey
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Win = 8
    }
}
