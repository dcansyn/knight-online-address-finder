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
        public string Dword { get; protected set; }
        public IntPtr Handle { get; protected set; }
        public List<OperationCodeBlock> Blocks { get; protected set; }
        
        public OperationCode(Game game, string dword, IntPtr handle)
        {
            Game = game;
            Dword = dword;
            Handle = handle;
        }

        public void UpdateBlock(List<OperationCodeBlock> blocks)
        {
            Blocks = blocks;
        }
    }
}
