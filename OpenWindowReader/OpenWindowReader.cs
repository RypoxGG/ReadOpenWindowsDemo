using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenWindowReader
{
    public static class OpenWindowReader
    {
        private delegate bool EnumThreadWndProc(IntPtr hwnd, IntPtr lParam);

        [DllImport("user32.Dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumThreadWindows(int dwThreadId, EnumThreadWndProc callback, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        public static IEnumerable<WindowDetail> GetOpenWindowsOfProcess(int processId)
        {
            var process = Process.GetProcessById(processId);
            return GetOpenWindowsOfProcess(process);
        }

        public static IEnumerable<WindowDetail> GetOpenWindowsOfProcess(string processName)
        {
            var processes = Process.GetProcessesByName(processName);
            foreach (var process in processes)
            {
               var windowDetails = GetOpenWindowsOfProcess(process);
                foreach (var windowDetail in windowDetails)
                {
                    yield return windowDetail;
                }
            }
        }

        public static IEnumerable<WindowDetail> GetOpenWindowsOfProcess(Process process)
        {
            var windowDetails = new List<WindowDetail>();
            var windowDetailsHandle = GCHandle.Alloc(windowDetails);
            var callback = new EnumThreadWndProc((hwnd, lParam) =>
            {
                if (GCHandle.FromIntPtr(lParam).Target is List<WindowDetail> list)
                {
                    var capacity = GetWindowTextLength(hwnd);
                    var stringBuilder = new StringBuilder(capacity * 2);
                    GetWindowText(hwnd, stringBuilder, stringBuilder.Capacity);
                    var windowDetail = new WindowDetail()
                    {
                        WindowHandle = hwnd,
                        WindowTitle = stringBuilder.ToString(),
                        Pid = process.Id
                    };
                    list.Add(windowDetail);
                }
                return true;
            });
            foreach (ProcessThread processThread in process.Threads)
            {
                EnumThreadWindows(processThread.Id, callback, GCHandle.ToIntPtr(windowDetailsHandle));
            }
            return windowDetails;
        }
    }
}
