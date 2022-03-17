using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Provider.Enums.Game
{
    public enum PlatformType : byte
    {
        [Display(Name = "Global")]
        Global,

        [Display(Name = "Steam")]
        Steam,

        [Display(Name = "Japan")]
        Japan
    }
}
