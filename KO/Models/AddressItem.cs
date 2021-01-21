using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Models
{
    public class AddressItem
    {
        public bool Active { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
        public string Hex { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public Enums.AddressType Type { get; set; }
        public string Pointer { get; set; }
        public string Call { get; set; }
        public int CallOffset { get; set; }
        public int PointerOffset { get; set; }
        public string BasePointer { get; set; }
    }
}
