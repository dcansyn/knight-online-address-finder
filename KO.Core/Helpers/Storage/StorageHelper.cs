using KO.Core.Consts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KO.Core.Helpers.Storage
{
    public class StorageHelper : WinApi
    {
        public static void Write(string path, string data)
        {
            var fileInfo = new FileInfo(path);

            if (!Directory.Exists(fileInfo.DirectoryName))
                Directory.CreateDirectory(fileInfo.DirectoryName);

            using (var st = new StreamWriter(path))
                st.Write(data);
        }

        public static string Read(string path)
        {
            if (!File.Exists(path))
                return null;

            return File.ReadAllText(path);
        }

        public static bool Exists(string path)
        {
            return File.Exists(path);
        }

        public static string ReadIni(string section, string key, string path)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", RetVal, 255, path);
            return RetVal.ToString();
        }

        public static void WriteIni(string section, string key, string value, string path)
        {
            WritePrivateProfileString(section, key, value, path);
        }
    }
}
