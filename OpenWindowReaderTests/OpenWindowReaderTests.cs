using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace OpenWindowReader.Tests
{
    [TestClass()]
    public class OpenWindowReaderTests
    {
        [TestMethod]
        public void GetOpenWindowsTest()
        {
            var process = Process.GetProcessesByName("devenv");
            var openWindows = OpenWindowReader.GetOpenWindowsOfProcess(process[0].Id);
            var processDetailsList = openWindows as IList<WindowDetail> ?? openWindows.ToList();
            foreach (var openWindow in processDetailsList)
            {
                Console.WriteLine(openWindow.WindowTitle);
            }
            Assert.IsTrue(processDetailsList.Any());
        }
    }
}