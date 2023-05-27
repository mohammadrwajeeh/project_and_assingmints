using System;
using System.Windows.Forms;

namespace TextEditor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate and run the MainForm
            Application.Run(new MainForm());
        }
    }
}
