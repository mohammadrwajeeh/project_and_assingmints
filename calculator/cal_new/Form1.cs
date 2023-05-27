using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        private TextBox number1TextBox;
        private TextBox number2TextBox;
        private ComboBox operationComboBox;
        private Button calculateButton;
        private Label resultLabel;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.number1TextBox = new TextBox();
            this.number2TextBox = new TextBox();
            this.operationComboBox = new ComboBox();
            this.calculateButton = new Button();
            this.resultLabel = new Label();
            this.SuspendLayout();

            // number1TextBox
            this.number1TextBox.Location = new System.Drawing.Point(12, 12);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(100, 20);
            this.number1TextBox.TabIndex = 0;

            // number2TextBox
            this.number2TextBox.Location = new System.Drawing.Point(12, 38);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(100, 20);
            this.number2TextBox.TabIndex = 1;

            // operationComboBox
            this.operationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            this.operationComboBox.Location = new System.Drawing.Point(12, 64);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(100, 21);
            this.operationComboBox.TabIndex = 2;

            // calculateButton
            this.calculateButton.Location = new System.Drawing.Point(12, 91);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);

            // resultLabel
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 127);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 4;

            // CalculatorForm
            this.ClientSize = new System.Drawing.Size(124, 150);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.number1TextBox);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(number1TextBox.Text, out double num1) &&
                double.TryParse(number2TextBox.Text, out double num2))
            {
                double result = 0;

                switch (operationComboBox.SelectedItem.ToString())
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Error: Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Error: Invalid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                resultLabel.Text = "Result: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Error: Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}
