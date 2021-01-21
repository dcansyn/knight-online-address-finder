using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KO.Helpers
{
    public class SaveHelper
    {
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        static string Section { get; set; }
        static string Path { get; set; }
        public SaveHelper(string _section, string _path)
        {
            Section = _section;
            Path = _path;
        }

        public void Write(string key, string value)
        {
            WritePrivateProfileString(Section, key, value, Path);
        }

        public string Read(string key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }
    }
}
