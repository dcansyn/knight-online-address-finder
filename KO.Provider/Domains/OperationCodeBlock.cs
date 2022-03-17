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
        public string OperationCode { get; protected set; }
        public int CallValue { get; protected set; }
        public int[] Rows { get; set; }

        public OperationCodeBlock(string hex, int callValue, int[] rows)
        {
            Hex = hex;
            ReverseBlocks = Hex.ConvertHexToBlocks();
            OperationCode = hex;
            CallValue = callValue;
            Rows = rows;

            Code();
        }

        public string Code()
        {
            var result = new List<string>();
            var max = Rows.Max();

            if (max >= ReverseBlocks.Length) return null;
            for (int i = 0; i <= max; i++)
                result.Add(Rows.Contains(i) ? ReverseBlocks[i] : "XX");

            result.Reverse();
            OperationCode = string.Join("", result);
            return OperationCode;
        }
    }
}