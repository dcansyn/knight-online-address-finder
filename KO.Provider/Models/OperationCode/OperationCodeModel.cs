using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Provider.Models.OperationCode
{
    public class OperationCodeModel
    {
        public string Dword { get; set; }
        public IntPtr Handle { get; set; }
        public string[] Blocks { get; set; }
    }
}
