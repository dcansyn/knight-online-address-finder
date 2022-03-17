using KO.Core.Extensions;
using KO.Provider.Enums.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Provider.Domains
{
    public class OperationCode
    {
        public Game Game { get; set; }
        public string Hex { get; protected set; }
        public string BaseHex { get; protected set; }
        public string Dword { get; protected set; }
        public string BaseDword { get; protected set; }
        public IntPtr Handle { get; protected set; }
        public AddressType AddressType { get; set; }
        public List<OperationCodeBlock> Blocks { get; protected set; }
        
        public OperationCode(Game game, string hex, IntPtr handle, string baseHex = "", AddressType addressType = AddressType.Pointer)
        {
            Game = game;
            Hex = hex;
            BaseHex = baseHex;
            Dword = Hex.ConvertHexToDword();
            BaseDword = BaseHex.ConvertHexToDword();
            Handle = handle;
            AddressType = addressType;
        }

        public void UpdateBlock(List<OperationCodeBlock> blocks)
        {
            Blocks = blocks;
        }
    }
}
