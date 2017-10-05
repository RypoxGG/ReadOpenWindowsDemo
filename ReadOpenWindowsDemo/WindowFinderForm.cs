using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ReadOpenWindowsDemo
{
    public partial class WindowFinderForm : Form
    {
        public WindowFinderForm()
        {
            InitializeComponent();
        }

        private void buttonFindWindows_Click(object sender, EventArgs e)
        {
            listBoxWindows.Items.Clear();
            var processes = Process.GetProcessesByName(textBoxProcessName.Text);
            if (string.IsNullOrWhiteSpace(textBoxProcessName.Text))
            {
                var openWindows = OpenWindowReader.OpenWindowReader.GetOpenWindowsOfProcess(0);
                foreach (var windowDetail in openWindows)
                {
                    listBoxWindows.Items.Add(windowDetail.WindowTitle);
                }
            }
            foreach (var process in processes)
            {
                var openWindows = OpenWindowReader.OpenWindowReader.GetOpenWindowsOfProcess(process.Id);
                foreach (var windowDetail in openWindows)
                {
                    listBoxWindows.Items.Add(windowDetail.WindowTitle);
                }
            }
        }

        private void buttonOpenNewForm_Click(object sender, EventArgs e)
        {
            var form = new UselessForm();
            form.Show();
        }
    }
}
