using KO.Core.Extensions;
using KO.Provider.Enums.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Provider.Domains
{
    public class Address
    {
        public bool Active { get; protected set; }
        public string Name { get; protected set; }
        public string Hex { get; protected set; }
        public int Start { get; protected set; } = 0x401000;
        public int Length { get; protected set; } = 0x5B2000;
        public int Value { get; protected set; }
        public string Result { get; protected set; }
        public int ResultOffset { get; protected set; }
        public string Call { get; protected set; }
        public int CallOffset { get; protected set; }
        public string BaseAddress { get; protected set; }
        public string BaseAddressName { get; protected set; }
        public AddressType Type { get; protected set; }
        public string FullResult => $"{Call} - {Result}";

        public Address(bool active,
            string name,
            string hex,
            int start = 0x401000,
            int length = 0x5B2000,
            int resultOffset = 0,
            int callOffset = 0,
            string baseAddressName = null,
            AddressType type = AddressType.Pointer)
        {
            Active = active;
            Name = name;
            Hex = hex;
            Start = start;
            Length = length;
            ResultOffset = resultOffset;
            CallOffset = callOffset;
            BaseAddressName = baseAddressName;
            Type = type;

            BeautyHex();
        }

        public void BeautyHex()
        {
            Hex = Hex.ToUpper().Replace("QQ", "XXXXXXXX");
        }

        public void UpdateBaseAddress(string baseAddress)
        {
            Hex = string.Format(Hex, baseAddress);
        }

        public void Find(int value, int result)
        {
            Value = value;
            Call = (Value - CallOffset).ConvertIntToHex();
            Result = Type == AddressType.Pointer ? (result + ResultOffset).ConvertIntToHex() : Call;
        }

        public Address Clone()
        {
            return (Address)MemberwiseClone();
        }
    }
}
