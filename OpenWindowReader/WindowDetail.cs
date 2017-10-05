using System;

namespace OpenWindowReader
{
    public class WindowDetail
    {
        public IntPtr WindowHandle { get; set; }
        public string WindowTitle { get; set; }
        public int Pid { get; set; }
    }
}