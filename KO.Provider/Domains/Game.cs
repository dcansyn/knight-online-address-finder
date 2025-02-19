using KO.Core.Consts;
using KO.Core.Extensions;
using KO.Core.Helpers.Memory;
using KO.Provider.Enums.Game;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace KO.Provider.Domains
{
    public class Game
    {
        public PlatformType PlatformType { get; protected set; }
        public string Title { get; protected set; }
        public IntPtr Handle { get; protected set; }
        public string FilePath { get; protected set; }
        public string FileName { get; protected set; }
        public Process GameProcess { get; protected set; }
        public bool IsStarted { get; protected set; } = false;
        public bool IsThreadAction { get; protected set; } = false;
        public bool IsCompleted { get; protected set; } = false;
        public DateTime ActionTime { get; protected set; }
        public bool IsAvailable => DateTime.Now > ActionTime;
        public List<Address> Addresses { get; protected set; }
        public EnumModel PlatformTypeData => PlatformType.Get();

        public Game(PlatformType platformType, string title)
        {
            PlatformType = platformType;
            Title = title;

            Handle = MemoryHelper.GetHandle(title);
        }

        public Game(PlatformType platformType, string name, string path)
        {
            PlatformType = platformType;
            Title = name;
            FilePath = path;

            ActionTime = DateTime.Now;
        }

        public void ChangeFolderName()
        {
            var info = new FileInfo(FilePath);
            if (info.Directory.FullName != null)
            {
                var xignCode = new DirectoryInfo(Path.Combine(info.Directory.FullName, "XIGNCODE"));
                if (xignCode.Exists)
                    Directory.Move(xignCode.FullName, xignCode.FullName + "1");
            }
        }

        public void RestoreFolderName()
        {
            var info = new FileInfo(FilePath);
            if (info.Directory.FullName != null)
            {
                var xignCode = new DirectoryInfo(Path.Combine(info.Directory.FullName, "XIGNCODE1"));
                if (xignCode.Exists)
                    Directory.Move(xignCode.FullName, Path.Combine(info.Directory.FullName, "XIGNCODE"));
            }
        }

        public void ChangeFileName()
        {
            var info = new FileInfo(FilePath);
            FileName = info.Name;
            var newFilePath = Path.Combine(info.Directory.FullName, $"{Title}.exe");
            File.Move(FilePath, newFilePath);
            FilePath = newFilePath;
        }

        public void RestoreFile()
        {
            var info = new FileInfo(FilePath);
            File.Move(FilePath, Path.Combine(info.Directory.FullName, FileName));
        }

        public void Start()
        {
            Task.Run(() =>
            {
                ChangeFileName();

                if (PlatformType == PlatformType.Global)
                    ChangeFolderName();

                var info = new FileInfo(FilePath);
                GameProcess = Process.Start(new ProcessStartInfo(info.Name)
                {
                    WindowStyle = ProcessWindowStyle.Minimized,
                    WorkingDirectory = info.Directory.FullName
                });

                RestoreFile();
            });

            ActionTime = DateTime.Now.AddMilliseconds(500);
            IsStarted = true;
        }

        public void Bypass()
        {
            Task.Run(() =>
            {
                if (PlatformType == PlatformType.Japan)
                    MemoryHelper.CloseMutant(GameProcess);

                WinApi.ShowWindow(GameProcess.MainWindowHandle, 6);
                WinApi.SetWindowText(GameProcess.MainWindowHandle, Title);
                MemoryHelper.ThreadSuspend(GameProcess);

                if (PlatformType == PlatformType.Global)
                    RestoreFolderName();

                IsCompleted = true;
            });

            ActionTime = DateTime.Now.AddMilliseconds(100);
            IsThreadAction = true;
        }

        public void UpdateAddresses(List<Address> addresses)
        {
            Addresses = addresses;
        }
    }
}
