using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FFX_PCSX2_Cheater.Utilities
{
    public static class WinAPI
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hProcess);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess,
IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }
        public static void WriteMem(Process p, IntPtr address, byte[] v)
        {
            var hProc = OpenProcess(ProcessAccessFlags.All, false, (int)p.Id);

            var val = v;

            int wtf = 0;
            WriteProcessMemory(hProc, address, val, (UInt32)val.LongLength, out wtf);

            CloseHandle(hProc);
        }

        public static byte[] ReadMem<T>(Process p, IntPtr address) where T: struct
        {
            var size = Marshal.SizeOf(typeof(T));
            var bytes = new byte[size];
            int readBytes = 0;

            var hProc = OpenProcess(ProcessAccessFlags.All, false, (int)p.Id);
            var result = ReadProcessMemory(hProc, address, bytes, size, ref readBytes);

            return bytes;
        }
    }
}
