using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class MainForm : Form
    {
        private Font selectedFont;
        private Color selectedColor;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set initial values
            selectedFont = richTextBox.Font;
            selectedColor = richTextBox.ForeColor;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Handle the open file operation
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Handle the save file operation
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Select all text in the editor
            richTextBox.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cut selected text from the editor
            richTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Copy selected text from the editor
            richTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Paste text into the editor
            richTextBox.Paste();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the font of the selected text or the whole text
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = selectedFont;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFont = fontDialog.Font;
                richTextBox.SelectionFont = selectedFont;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the color of the selected text or the whole text
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = selectedColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
                richTextBox.SelectionColor = selectedColor;
            }
        }
    }
}
