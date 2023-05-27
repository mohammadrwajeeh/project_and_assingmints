using static System.Net.Mime.MediaTypeNames;

namespace cal_new
{
    partial class Form1 : Form1Base
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SizeF AutoScaleDimensions { get; private set; }
        public AutoScaleMode AutoScaleMode { get; private set; }
        public Size ClientSize { get; private set; }
        public string Name { get; private set; }
        public string Text { get; private set; }
        public int Load { get; private set; }
        public int Form1_Load { get; private set; }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private void ResumeLayout(bool v)
        {
            throw new NotImplementedException();
        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}