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
            if (string.IsNullOrWhiteSpace(textBoxProcessName.Text))
            {
                var allOpenWindows = OpenWindowReader.OpenWindowReader.GetOpenWindowsOfProcess(0);
                foreach (var windowDetail in allOpenWindows)
                {
                    listBoxWindows.Items.Add(windowDetail.WindowTitle);
                }
            }
                var openWindows = OpenWindowReader.OpenWindowReader.GetOpenWindowsOfProcess(textBoxProcessName.Text);
                foreach (var windowDetail in openWindows)
                {
                    listBoxWindows.Items.Add(windowDetail.WindowTitle);
                }
        }

        private void buttonOpenNewForm_Click(object sender, EventArgs e)
        {
            var form = new UselessForm();
            form.Show();
        }
    }
}
