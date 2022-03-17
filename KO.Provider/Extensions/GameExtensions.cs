using KO.Core.Consts;
using KO.Core.Extensions;
using KO.Provider.Models.OperationCode;
using System;
using System.Collections.Generic;

namespace KO.Provider.Extensions
{
    public static class GameExtensions
    {
        public static int ReadAddress(this IntPtr handle, string operationCode, int start, int length)
        {
            if (string.IsNullOrEmpty(operationCode) || start <= 0 || length <= 0)
                return 0;

            var operationCodes = operationCode.ConvertStringToByteArray();
            for (int k = start; k < (start + length); k += 0x1000)
            {
                var addresses = handle.ReadByteArray(k, 0x1000);
                for (int i = 0; i < addresses.Length; i++)
                {
                    if (addresses[i] == operationCodes[0])
                    {
                        var matchAddress = true;
                        for (int j = 0; j < operationCodes.Length; j++)
                        {
                            var key = operationCode.Substring(j * 2, 2);
                            if (key != "XX" && (i + j >= addresses.Length || addresses[i + j] != operationCodes[j]))
                            {
                                matchAddress = false;
                                break;
                            }
                        }
                        if (matchAddress)
                            return k + i;
                    }
                }
            }
            return 0;
        }

        public static byte[] ReadByteArray(this IntPtr handle, int address, int bufferLen)
        {
            if (bufferLen < 0) bufferLen = 0;
            var buffer = new byte[bufferLen];
            try
            {
                WinApi.ReadProcessMemory(handle, new IntPtr(address), buffer, (uint)bufferLen, out _);
                return buffer;
            }
            catch (Exception) { }
            return buffer;
        }

        public static int ReadLong(this IntPtr handle, int address)
        {
            uint ret;
            try
            {
                WinApi.ReadProcessMemory(handle, new IntPtr(address), out ret, 4, new IntPtr());
            }
            catch (Exception)
            {
                ret = 0;
            }
            return (int)ret;
        }
    }
}
