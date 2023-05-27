using System;
using System.Drawing;
using System.Windows.Forms;

namespace DynamicControlsApp
{
    public partial class Form1 : Form
    {
        private int controlCount = 0; // Counter for generated controls

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up the initial state of the form
            cmbControlType.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Control newControl = null;

            // Get the selected control type from the ComboBox
            string selectedControl = cmbControlType.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedControl))
            {
                // Create a new instance of the selected control type
                switch (selectedControl)
                {
                    case "TextBox":
                        newControl = new TextBox();
                        ((TextBox)newControl).TextChanged += new EventHandler(Control_TextChanged); // Add event handler
                        break;
                    case "CheckBox":
                        newControl = new CheckBox();
                        ((CheckBox)newControl).CheckedChanged += new EventHandler(Control_CheckedChanged); // Add event handler
                        break;
                    case "Button":
                        newControl = new Button();
                        ((Button)newControl).Click += new EventHandler(Control_Click); // Add event handler
                        break;
                        // Add more cases for other control types as needed
                }

                if (newControl != null)
                {
                    // Set properties for the new control
                    newControl.Name = $"dynamicControl{controlCount++}"; // Assign a unique name
                    newControl.Location = new Point(20, 50 + controlCount * 30); // Set the initial location
                    newControl.Width = 150; // Set the width

                    // Create a label for the control
                    Label lblControl = new Label();
                    lblControl.Text = $"{selectedControl} {controlCount}";
                    lblControl.AutoSize = true;
                    lblControl.Location = new Point(180, newControl.Location.Y + 4);

                    // Add the new control and label to the form's Controls collection
                    this.Controls.Add(newControl);
                    this.Controls.Add(lblControl);
                }
            }
        }

        // Event handler for TextBox TextChanged event
        private void Control_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // Do something with the TextBox text
            MessageBox.Show($"Text changed: {textBox.Text}");
        }

        // Event handler for CheckBox CheckedChanged event
        private void Control_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            // Do something with the CheckBox checked state
            MessageBox.Show($"Checked: {checkBox.Checked}");
        }

        // Event handler for Button Click event
        private void Control_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // Do something when the Button is clicked
            MessageBox.Show($"Button clicked: {button.Text}");
        }
    }
}
