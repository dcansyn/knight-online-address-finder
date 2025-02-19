using KO.Core.Enums.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KO.Core.Consts
{
    public class WinApi
    {
        #region [Structs]
        [StructLayout(LayoutKind.Sequential)]
        public struct OBJECT_TYPE_INFORMATION
        {
            public UNICODE_STRING Name;
            public int ObjectCount;
            public int HandleCount;
            public int Reserved1;
            public int Reserved2;
            public int Reserved3;
            public int Reserved4;
            public int PeakObjectCount;
            public int PeakHandleCount;
            public int Reserved5;
            public int Reserved6;
            public int Reserved7;
            public int Reserved8;
            public int InvalidAttributes;
            public GENERIC_MAPPING GenericMapping;
            public int ValidAccess;
            public byte Unknown;
            public byte MaintainHandleDatabase;
            public int PoolType;
            public int PagedPoolUsage;
            public int NonPagedPoolUsage;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct OBJECT_NAME_INFORMATION
        {
            public UNICODE_STRING Name;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct UNICODE_STRING
        {
            public ushort Length;
            public ushort MaximumLength;
            public IntPtr Buffer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GENERIC_MAPPING
        {
            public int GenericRead;
            public int GenericWrite;
            public int GenericExecute;
            public int GenericAll;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct SYSTEM_HANDLE_INFORMATION
        {
            public int ProcessID;
            public byte ObjectTypeNumber;
            public byte Flags;
            public ushort Handle;
            public int Object_Pointer;
            public uint GrantedAccess;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct OBJECT_BASIC_INFORMATION
        {
            public int Attributes;
            public int GrantedAccess;
            public int HandleCount;
            public int PointerCount;
            public int PagedPoolUsage;
            public int NonPagedPoolUsage;
            public int Reserved1;
            public int Reserved2;
            public int Reserved3;
            public int NameInformationLength;
            public int TypeInformationLength;
            public int SecurityDescriptorLength;
            public System.Runtime.InteropServices.ComTypes.FILETIME CreateTime;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STARTUPINFO
        {
            public uint cb;
            public IntPtr lpReserved;
            public IntPtr lpDesktop;
            public IntPtr lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttributes;
            public uint dwFlags;
            public ushort wShowWindow;
            public ushort cbReserved;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdErr;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STARTUPINFOEX
        {
            public STARTUPINFO StartupInfo;
            public IntPtr lpAttributeList;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_ATTRIBUTES
        {
            public int nLength;
            public IntPtr lpSecurityDescriptor;
            public int bInheritHandle;
        }

        [Flags]
        public enum CreationFlags
        {
            CreateSuspended = 0x00000004,
            DetachedProcess = 0x00000008,
            CreateNoWindow = 0x08000000,
            CreateUnicodeEnv = 0x00000400
        }
        #endregion

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DuplicateHandle(IntPtr hSourceProcessHandle, ushort hSourceHandle, IntPtr hTargetProcessHandle, out IntPtr lpTargetHandle, uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwOptions);
        [DllImport("ntdll.dll")]
        public static extern int NtQueryObject(IntPtr objectHandle, int objectInformationClass, IntPtr objectInformation, int objectInformationLength, ref int returnLength);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint QueryDosDevice(string lpDeviceName, StringBuilder lpTargetPath, int ucchMax);
        [DllImport("ntdll.dll")]
        public static extern uint NtQuerySystemInformation(int systemInformationClass, IntPtr systemInformation, int systemInformationLength, ref int returnLength);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr OpenMutex(uint desiredAccess, bool inheritHandle, string name);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetCurrentProcess();
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, out UInt32 buffer, UInt32 size, IntPtr lpNumberOfBytesRead);
        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);
        [DllImport("user32.dll")]
        public static extern int SetWindowText(IntPtr hWnd, string text);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        public static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        public static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        public static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        public static extern int ResumeThread(IntPtr hThread);
        [DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr VirtualAllocEx(IntPtr hpProcess, IntPtr lpAddress, int dwSize, int flAllocationType, int flProtect);
        [DllImport("ntdll.dll")]
        public static extern void NtResumeProcess(IntPtr processHandle);
        [DllImport("ntdll.dll")]
        public static extern void NtSuspendProcess(IntPtr processHandle);
    }
}
