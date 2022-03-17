using KO.Core.Consts;
using KO.Core.Enums.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO.Core.Helpers.Memory
{
    public class MemoryHelper : WinApi
    {
        public static IntPtr GetHandle(string title)
        {
            GetWindowThreadProcessId(FindWindow(null, title), out int pid);
            return OpenProcess(ProcessAccessFlags.All, false, pid);
        }

        public static List<Process> GetProcesses(string[] names)
        {
            return Process.GetProcesses()
                .Where(x => names.Contains(x.MainWindowTitle))
                .ToList();
        }

        public static Process GetProcessByTitle(string title)
        {
            return Process.GetProcesses().FirstOrDefault(x => x.MainWindowTitle == title);  
        }

        public static IntPtr GetHandleByTitle(string title)
        {
            GetWindowThreadProcessId(FindWindow(null, title), out int pid);
            return OpenProcess(ProcessAccessFlags.All, false, pid);
        }

        public static void Wait(int miliseconds)
        {
            var now = DateTime.Now.AddMilliseconds(miliseconds);

            while (now > DateTime.Now)
                Application.DoEvents();
        }

        public static void KillByTitle(string title, bool contains = true)
        {
            Process.GetProcesses()
                .Where(x => contains ? x.MainWindowTitle.Contains(title) : x.MainWindowTitle == title)
                .ToList()
                .ForEach(item =>
                {
                    item.Kill();
                });
        }

        public static void KillByName(string name, bool contains = true)
        {
            Process.GetProcesses()
                .Where(x => contains ? x.ProcessName.Contains(name) : x.ProcessName == name)
                .ToList()
                .ForEach(item =>
                {
                    item.Kill();
                });
        }

        public static bool CheckProcessByName(string name)
        {
            return Process.GetProcesses().Any(x => x.ProcessName == name);
        }

        public static bool CheckProcessByTitle(string title)
        {
            return Process.GetProcesses().Any(x => x.MainWindowTitle == title);
        }

        public static void ThreadSuspend(Process process)
        {
            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero) continue;

                SuspendThread(pOpenThread);
                CloseHandle(pOpenThread);
            }
        }

        public static void ThreadResume(Process process)
        {
            if (process.ProcessName == string.Empty) return;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero) continue;

                var suspendCount = 0;
                do
                {
                    suspendCount = ResumeThread(pOpenThread);
                } while (suspendCount > 0);

                CloseHandle(pOpenThread);
            }
        }

        public static Process OpenProcess(string path)
        {
            var info = new FileInfo(path);
            return Process.Start(new ProcessStartInfo(info.Name) 
            { 
                WorkingDirectory = info.Directory.FullName
            });
        }

        public static void OpenParentProcess(string path)
        {
            var processerPath = Path.Combine(Environment.CurrentDirectory, "KO.Processer.exe");
            var fileInfo = new FileInfo(processerPath);
            if (!fileInfo.Exists) throw new ArgumentNullException("Processer not found.");

            using (var managementClass = new ManagementClass("Win32_Process"))
            {
                var processInfo = new ManagementClass("Win32_ProcessStartup");
                var inParameters = managementClass.GetMethodParameters("Create");
                inParameters["CommandLine"] = $"{processerPath} {path}";
                inParameters["CurrentDirectory"] = fileInfo.Directory.FullName;
                inParameters["ProcessStartupInformation"] = processInfo;

                managementClass.InvokeMethod("Create", inParameters, null);
            }
        }

        #region [Kill Mutant]
        // https://stackoverflow.com/q/39311863/3024129
        public static void CloseMutant(Process process)
        {
            try
            {
                var handles = GetHandles(process, "Mutant", App.GameName);

                if (handles.Count != 0)
                    foreach (var handle in handles)
                    {
                        DuplicateHandle(Process.GetProcessById(handle.ProcessID).Handle, handle.Handle, GetCurrentProcess(), out IntPtr ipHandle, 0, false, 0x1);
                        CloseHandle(ipHandle);
                    }
            }
            catch (IndexOutOfRangeException) { }
            catch (ArgumentException) { }
        }

        public static bool Is64Bits()
        {
            return Marshal.SizeOf(typeof(IntPtr)) == 8;
        }

        public static List<SYSTEM_HANDLE_INFORMATION> GetHandles(Process process = null, string IN_strObjectTypeName = null, string IN_strObjectName = null)
        {
            int nHandleInfoSize = 0x10000;
            IntPtr ipHandlePointer = Marshal.AllocHGlobal(nHandleInfoSize);
            int nLength = 0;
            while ((_ = NtQuerySystemInformation(16, ipHandlePointer, nHandleInfoSize, ref nLength)) == 0xC0000004)
            {
                nHandleInfoSize = nLength;
                Marshal.FreeHGlobal(ipHandlePointer);
                ipHandlePointer = Marshal.AllocHGlobal(nLength);
            }

            byte[] baTemp = new byte[nLength];
            Marshal.Copy(ipHandlePointer, baTemp, 0, nLength);
            IntPtr ipHandle;

            long lHandleCount;
            if (Is64Bits())
            {
                lHandleCount = Marshal.ReadInt64(ipHandlePointer);
                ipHandle = new IntPtr(ipHandlePointer.ToInt64() + 8);
            }
            else
            {
                lHandleCount = Marshal.ReadInt32(ipHandlePointer);
                ipHandle = new IntPtr(ipHandlePointer.ToInt32() + 4);
            }

            SYSTEM_HANDLE_INFORMATION shHandle;
            List<SYSTEM_HANDLE_INFORMATION> lstHandles = new List<SYSTEM_HANDLE_INFORMATION>();

            for (long lIndex = 0; lIndex < lHandleCount; lIndex++)
            {
                shHandle = new SYSTEM_HANDLE_INFORMATION();
                if (Is64Bits())
                {
                    shHandle = (SYSTEM_HANDLE_INFORMATION)Marshal.PtrToStructure(ipHandle, shHandle.GetType());
                    ipHandle = new IntPtr(ipHandle.ToInt64() + Marshal.SizeOf(shHandle) + 8);
                }
                else
                {
                    ipHandle = new IntPtr(ipHandle.ToInt64() + Marshal.SizeOf(shHandle));
                    shHandle = (SYSTEM_HANDLE_INFORMATION)Marshal.PtrToStructure(ipHandle, shHandle.GetType());
                }

                if (process != null)
                {
                    if (shHandle.ProcessID != process.Id) continue;
                }

                if (IN_strObjectTypeName != null)
                {
                    var strObjectTypeName = GetObjectTypeName(shHandle, Process.GetProcessById(shHandle.ProcessID));
                    if (strObjectTypeName != IN_strObjectTypeName) continue;
                }

                if (IN_strObjectName != null)
                {
                    var strObjectName = GetObjectName(shHandle, Process.GetProcessById(shHandle.ProcessID));
                    if (string.IsNullOrEmpty(strObjectName) || !strObjectName.Contains(IN_strObjectName)) continue;
                }

                lstHandles.Add(shHandle);
            }
            return lstHandles;
        }

        public static string GetObjectName(SYSTEM_HANDLE_INFORMATION shHandle, Process process)
        {
            var m_ipProcessHwnd = OpenProcess(ProcessAccessFlags.All, false, process.Id);
            var objBasic = new OBJECT_BASIC_INFORMATION();
            var objObjectName = new OBJECT_NAME_INFORMATION();
            int nLength = 0;
            if (!DuplicateHandle(m_ipProcessHwnd, shHandle.Handle, GetCurrentProcess(),
                                          out IntPtr ipHandle, 0, false, 0x2))
                return null;

            var ipBasic = Marshal.AllocHGlobal(Marshal.SizeOf(objBasic));
            NtQueryObject(ipHandle, (int)ObjectInformationClass.ObjectBasicInformation,
                                   ipBasic, Marshal.SizeOf(objBasic), ref nLength);
            objBasic = (OBJECT_BASIC_INFORMATION)Marshal.PtrToStructure(ipBasic, objBasic.GetType());
            Marshal.FreeHGlobal(ipBasic);


            nLength = objBasic.NameInformationLength;

            IntPtr ipObjectName = Marshal.AllocHGlobal(nLength);
            while ((uint)(_ = NtQueryObject(
                     ipHandle, (int)ObjectInformationClass.ObjectNameInformation,
                     ipObjectName, nLength, ref nLength))
                   == 0xC0000004)
            {
                Marshal.FreeHGlobal(ipObjectName);
                ipObjectName = Marshal.AllocHGlobal(nLength);
            }
            objObjectName = (OBJECT_NAME_INFORMATION)Marshal.PtrToStructure(ipObjectName, objObjectName.GetType());

            IntPtr ipTemp;
            if (Is64Bits())
            {
                ipTemp = new IntPtr(Convert.ToInt64(objObjectName.Name.Buffer.ToString(), 10) >> 32);
            }
            else
            {
                ipTemp = objObjectName.Name.Buffer;
            }

            if (ipTemp != IntPtr.Zero)
            {

                byte[] baTemp2 = new byte[nLength];
                try
                {
                    Marshal.Copy(ipTemp, baTemp2, 0, nLength);

                    string strObjectName = Marshal.PtrToStringUni(Is64Bits() ?
                                               new IntPtr(ipTemp.ToInt64()) :
                                               new IntPtr(ipTemp.ToInt32()));
                    return strObjectName;
                }
                catch (AccessViolationException)
                {
                    return null;
                }
                finally
                {
                    Marshal.FreeHGlobal(ipObjectName);
                    CloseHandle(ipHandle);
                }
            }
            return null;
        }

        public static string GetObjectTypeName(SYSTEM_HANDLE_INFORMATION shHandle, Process process)
        {
            IntPtr m_ipProcessHwnd = OpenProcess(ProcessAccessFlags.All, false, process.Id);
            var objBasic = new OBJECT_BASIC_INFORMATION();
            var objObjectType = new OBJECT_TYPE_INFORMATION();
            int nLength = 0;
            if (!DuplicateHandle(m_ipProcessHwnd, shHandle.Handle,
                                          GetCurrentProcess(), out IntPtr ipHandle,
                                          0, false, 0x2))
                return null;

            IntPtr ipBasic = Marshal.AllocHGlobal(Marshal.SizeOf(objBasic));
            NtQueryObject(ipHandle, (int)ObjectInformationClass.ObjectBasicInformation,
                                   ipBasic, Marshal.SizeOf(objBasic), ref nLength);
            objBasic = (OBJECT_BASIC_INFORMATION)Marshal.PtrToStructure(ipBasic, objBasic.GetType());
            Marshal.FreeHGlobal(ipBasic);

            IntPtr ipObjectType = Marshal.AllocHGlobal(objBasic.TypeInformationLength);
            nLength = objBasic.TypeInformationLength;
            while ((uint)(_ = NtQueryObject(
                ipHandle, (int)ObjectInformationClass.ObjectTypeInformation, ipObjectType,
                  nLength, ref nLength)) ==
                0xC0000004)
            {
                Marshal.FreeHGlobal(ipObjectType);
                ipObjectType = Marshal.AllocHGlobal(nLength);
            }

            objObjectType = (OBJECT_TYPE_INFORMATION)Marshal.PtrToStructure(ipObjectType, objObjectType.GetType());
            IntPtr ipTemp;
            if (Is64Bits())
            {
                ipTemp = new IntPtr(Convert.ToInt64(objObjectType.Name.Buffer.ToString(), 10) >> 32);
            }
            else
            {
                ipTemp = objObjectType.Name.Buffer;
            }

            string strObjectTypeName = Marshal.PtrToStringUni(ipTemp, objObjectType.Name.Length >> 1);
            Marshal.FreeHGlobal(ipObjectType);
            return strObjectTypeName;
        }
        #endregion
    }
}
