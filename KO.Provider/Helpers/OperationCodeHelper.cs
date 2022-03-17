using KO.Core.Consts;
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
        public static void FindOperationCode(int[] rows, int start = 0x401000, int length = 0x5B2000)
        {
            foreach (var code in Client.Codes)
            {
                var blocks = new List<OperationCodeBlock>();
                for (int i = start; i < (start + length); i += 0x1000)
                {
                    Application.DoEvents();

                    var handleHexBlock = code.Handle.ReadByteArray(i, 0x1000).ConvertByteArrayToHex();
                    switch (code.AddressType)
                    {
                        case Enums.Address.AddressType.Pointer:
                        case Enums.Address.AddressType.Offset:
                            if (handleHexBlock.Contains(code.Dword))
                            {
                                var addressHexBlocks = handleHexBlock.Split(new[] { code.Dword }, StringSplitOptions.RemoveEmptyEntries);
                                var addressHexBlockLength = 0;
                                for (int b = 0; b < addressHexBlocks.Length - 1; b++)
                                {
                                    Application.DoEvents();

                                    var addressHexBlock = addressHexBlocks[b];
                                    addressHexBlockLength += addressHexBlock.Length;

                                    var hexBlock = addressHexBlock.Length >= App.OperationCodeMaxLength ?
                                        addressHexBlock.Substring(addressHexBlock.Length - App.OperationCodeMaxLength)
                                        :
                                        code.Handle.ReadByteArray(i - App.OperationCodeMaxLength + (addressHexBlockLength / 2), App.OperationCodeMaxLength).ConvertByteArrayToHex();

                                    var callValue = i + addressHexBlockLength / 2;

                                    blocks.Add(new OperationCodeBlock(hexBlock, callValue, rows));
                                    addressHexBlockLength += 8;
                                }
                            }
                            break;
                        case Enums.Address.AddressType.Call:
                            if (handleHexBlock.Contains("E8"))
                            {
                                var addressHexBlocks = handleHexBlock.Split(new[] { "E8" }, StringSplitOptions.RemoveEmptyEntries);
                                var addressHexBlockLength = addressHexBlocks[0].Length;
                                for (int b = 1; b < addressHexBlocks.Length; b++)
                                {
                                    Application.DoEvents();

                                    var addressHexBlock = addressHexBlocks[b];
                                    addressHexBlockLength += addressHexBlock.Length;

                                    var callDwordBlock = addressHexBlock.Length >= 8 ?
                                        addressHexBlock.Substring(0, 8)
                                        :
                                        code.Handle.ReadByteArray(i - ((addressHexBlock.Length / 2) - 1) + (addressHexBlockLength / 2), 4).ConvertByteArrayToHex();
                                    
                                    var callValue = i - (addressHexBlock.Length / 2) + (addressHexBlockLength / 2);
                                    var callAddressHex = (callValue + callDwordBlock.ConvertHexToDword().ConvertHexToInt() + 5).ConvertIntToHex();
                                    if(callAddressHex == code.Hex)
                                    {
                                        var hexBlock = $"{addressHexBlocks[b - 1]}E8";
                                        if (hexBlock.Length > App.OperationCodeMaxLength)
                                            hexBlock = hexBlock.Substring(hexBlock.Length - App.OperationCodeMaxLength);

                                        if (hexBlock.Length % 2 != 0)
                                            hexBlock = hexBlock.Substring(1);

                                        if (hexBlock.Length <= 8) continue;

                                        blocks.Add(new OperationCodeBlock(hexBlock, callValue, rows));
                                    }
                                    addressHexBlockLength += 2;
                                }
                            }
                            break;
                        default:
                            break;
                    }

                }
                code.UpdateBlock(blocks);
            }
        }

        public static void UpdateOperationCode()
        {
            for (int i = 0; i < Client.Codes.Count; i++)
            {
                var first = Client.Codes[i];
                var second = Client.Codes[i >= Client.Codes.Count - 1 ? 0 : i + 1];

                var blocks = new List<OperationCodeBlock>();
                foreach (var item in first.Blocks)
                {
                    Application.DoEvents();
                    var firstCode = item.Code();

                    if (second.Blocks.Any(x => x.OperationCode == item.OperationCode))
                        blocks.Add(item);
                }

                first.UpdateBlock(blocks);
                second.UpdateBlock(blocks);
            }
        }
    }
}
