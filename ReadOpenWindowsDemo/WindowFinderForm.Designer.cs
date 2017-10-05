namespace ReadOpenWindowsDemo
{
    partial class WindowFinderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.buttonFindWindows = new System.Windows.Forms.Button();
            this.listBoxWindows = new System.Windows.Forms.ListBox();
            this.labelProcessName = new System.Windows.Forms.Label();
            this.buttonOpenNewForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcessName.Location = new System.Drawing.Point(12, 30);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(408, 20);
            this.textBoxProcessName.TabIndex = 0;
            this.textBoxProcessName.Text = "ReadOpenWindowsDemo";
            // 
            // buttonFindWindows
            // 
            this.buttonFindWindows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindWindows.Location = new System.Drawing.Point(114, 62);
            this.buttonFindWindows.Name = "buttonFindWindows";
            this.buttonFindWindows.Size = new System.Drawing.Size(222, 48);
            this.buttonFindWindows.TabIndex = 1;
            this.buttonFindWindows.Text = "Find Windows";
            this.buttonFindWindows.UseVisualStyleBackColor = true;
            this.buttonFindWindows.Click += new System.EventHandler(this.buttonFindWindows_Click);
            // 
            // listBoxWindows
            // 
            this.listBoxWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxWindows.FormattingEnabled = true;
            this.listBoxWindows.Location = new System.Drawing.Point(12, 116);
            this.listBoxWindows.Name = "listBoxWindows";
            this.listBoxWindows.Size = new System.Drawing.Size(408, 420);
            this.listBoxWindows.TabIndex = 2;
            // 
            // labelProcessName
            // 
            this.labelProcessName.AutoSize = true;
            this.labelProcessName.Location = new System.Drawing.Point(12, 14);
            this.labelProcessName.Name = "labelProcessName";
            this.labelProcessName.Size = new System.Drawing.Size(79, 13);
            this.labelProcessName.TabIndex = 3;
            this.labelProcessName.Text = "Process Name:";
            // 
            // buttonOpenNewForm
            // 
            this.buttonOpenNewForm.Location = new System.Drawing.Point(15, 62);
            this.buttonOpenNewForm.Name = "buttonOpenNewForm";
            this.buttonOpenNewForm.Size = new System.Drawing.Size(93, 48);
            this.buttonOpenNewForm.TabIndex = 4;
            this.buttonOpenNewForm.Text = "Open New Form";
            this.buttonOpenNewForm.UseVisualStyleBackColor = true;
            this.buttonOpenNewForm.Click += new System.EventHandler(this.buttonOpenNewForm_Click);
            // 
            // WindowFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 538);
            this.Controls.Add(this.buttonOpenNewForm);
            this.Controls.Add(this.labelProcessName);
            this.Controls.Add(this.listBoxWindows);
            this.Controls.Add(this.buttonFindWindows);
            this.Controls.Add(this.textBoxProcessName);
            this.Name = "WindowFinderForm";
            this.Text = "Window Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.Button buttonFindWindows;
        private System.Windows.Forms.ListBox listBoxWindows;
        private System.Windows.Forms.Label labelProcessName;
        private System.Windows.Forms.Button buttonOpenNewForm;
    }
}

