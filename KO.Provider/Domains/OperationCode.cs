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
        public string Dword { get; protected set; }
        public IntPtr Handle { get; protected set; }
        public List<OperationCodeBlock> Blocks { get; protected set; }
        
        public OperationCode(Game game, string hex, IntPtr handle)
        {
            Game = game;
            Hex = hex;
            Dword = Hex.ConvertHexToDword();
            Handle = handle;
        }

        public void UpdateBlock(List<OperationCodeBlock> blocks)
        {
            Blocks = blocks;
        }
    }
}
