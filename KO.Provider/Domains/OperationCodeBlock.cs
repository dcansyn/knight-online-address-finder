using KO.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Provider.Domains
{
    public class OperationCodeBlock
    {
        public string Hex { get; protected set; }
        public string[] ReverseBlocks { get; protected set; }
        public string FirstBlock => ReverseBlocks.Length > 0 ? ReverseBlocks[0] : "";
        public int Start { get; protected set; }
        public string OperationCode { get; protected set; }

        public OperationCodeBlock(string hex, int start)
        {
            Hex = hex;
            Start = start;
            ReverseBlocks = Hex.ConvertHexToBlocks();
            OperationCode = hex;
        }

        public string Code(int[] counts)
        {
            var result = new List<string>();
            var max = counts.Max();
            
            if (max >= ReverseBlocks.Length) throw new ArgumentOutOfRangeException();
            for(int i = 0; i <= max; i++)
                result.Add(counts.Contains(i) ? ReverseBlocks[i] : "XX");

            result.Reverse();
            OperationCode = string.Join("", result);
            return OperationCode;
        }
    }
}