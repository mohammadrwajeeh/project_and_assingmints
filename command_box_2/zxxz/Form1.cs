namespace zxxz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateControls_Click(object sender, EventArgs e)
        {
            int NumberOfControls = int.Parse(txtNumOfControls.Text);

            if (comControlType.Text == "Button")
            {
                for (int i = 0; i < NumberOfControls; i++)
                {
                    Button NewButton = new Button();
                    NewButton.Name = "Button" + (i + 1);
                    NewButton.Text = "Button" + (i + 1);
                    NewButton.Size = new Size(120, 40);
                    NewButton.Location = new Point(0, i * 50);
                    pnlDynamicControls.Controls.Add(NewButton);

                }
            }

            if (comControlType.Text == "TextBox")
            {
                for (int i = 0; i < NumberOfControls; i++)
                {
                    TextBox NewTextBox = new TextBox();
                    NewTextBox.Name = "TextBox" + (i + 1);
                    NewTextBox.Text = "TextBox" + (i + 1);
                    NewTextBox.Size = new Size(120, 40);
                    NewTextBox.Location = new Point(150, i * 50);
                    pnlDynamicControls.Controls.Add(NewTextBox);


                }
            }

            if (comControlType.Text == "Label")
            {
                for (int i = 0; i < NumberOfControls; i++)
                {
                    Label NewLabel = new Label();
                    NewLabel.Name = "Label" + (i + 1);
                    NewLabel.Text = "Label" + (i + 1);
                    NewLabel.Size = new Size(120, 40);
                    NewLabel.Location = new Point(300, i * 50);
                    pnlDynamicControls.Controls.Add(NewLabel);


                }
            }
        }
    }
}