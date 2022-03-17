using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Core.Extensions
{
    public static class ConvertExtensions
    {
        public static string ConvertByteArrayToHex(this byte[] value)
        {
            return string.Join("", value.Select(x => x.ToString("x2"))).ToUpper();
        }

        public static string ConvertByteArrayToString(this byte[] value)
        {
            try
            {
                return string.Join("", value.Select(x => Convert.ToChar(x)));
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static int ConvertHexToInt(this string value)
        {
            return Convert.ToInt32(value, 16);
        }

        public static string ConvertIntToHex(this int value)
        {
            return value.ToString("x2").ToUpper();
        }

        public static string ConvertHexToDword(this string value)
        {
            if (string.IsNullOrEmpty(value)) return "";

            return string.Join("", BitConverter.GetBytes(value.ConvertHexToInt()).Select(x => x.ToString("x2"))).ToUpper();
        }

        public static byte[] ConvertStringToByteArray(this string value)
        {
            var result = new List<byte>();

            for (int i = 0; i < value.Length; i += 2)
                if (byte.TryParse(value.Substring(i, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out byte val))
                    result.Add(val);
                else
                    result.Add(0);

            return result.ToArray();
        }

        public static string[] ConvertHexToBlocks(this string value)
        {
            var result = new List<string>();

            for (int i = 0; i < value.Length; i += 2)
                result.Add(value.Substring(i, 2));

            result.Reverse();
            return result.ToArray();
        }
    }
}
