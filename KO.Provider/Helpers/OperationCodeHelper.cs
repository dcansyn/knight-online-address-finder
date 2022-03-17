using KO.Core.Extensions;
using KO.Provider.Domains;
using KO.Provider.Extensions;
using KO.Provider.Models.OperationCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO.Provider.Helpers
{
    public class OperationCodeHelper
    {
        public static void FindOperationCode(int start = 0x401000, int length = 0x5B2000)
        {
            foreach (var code in Client.Codes)
            {
                var blocks = new List<OperationCodeBlock>();
                for (int i = start; i < (start + length); i += 0x1000)
                {
                    var handleHexBlock = code.Handle.ReadByteArray(i, 0x1000).ConvertByteArrayToHex();
                    if (handleHexBlock.Contains(code.Dword))
                    {
                        var startIndex = i - 20 + (handleHexBlock.IndexOf(code.Dword) / 2);
                        var hexBlock = code.Handle.ReadByteArray(startIndex, 20).ConvertByteArrayToHex();

                        blocks.Add(new OperationCodeBlock(hexBlock, startIndex));
                    }

                    Application.DoEvents();
                }
                code.UpdateBlock(blocks);
            }
        }

        public static void UpdateOperationCode(int[] rows = null)
        {
            for (int i = 0; i < Client.Codes.Count; i++)
            {
                var first = Client.Codes[i];
                var second = Client.Codes[i >= Client.Codes.Count - 1 ? 0 : i + 1];

                var blocks = new List<OperationCodeBlock>();
                foreach (var item in first.Blocks)
                {
                    if (rows != null && second.Blocks.Any(x => x.Code(rows) == item.Code(rows)))
                        blocks.Add(item);
                    else if (second.Blocks.Any(x => x.FirstBlock == item.FirstBlock))
                        blocks.Add(item);

                    Application.DoEvents();
                }

                first.UpdateBlock(blocks);
                second.UpdateBlock(blocks);
            }
        }
    }
}
