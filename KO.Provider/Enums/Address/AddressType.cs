using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Provider.Enums.Address
{
    public enum AddressType : byte
    {
        [Display(Name = "Pointer")]
        Pointer,

        [Display(Name = "Offset")]
        Offset,

        [Display(Name = "Call")]
        Call
    }
}
