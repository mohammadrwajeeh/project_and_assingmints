namespace DynamicControlsApp
{
    partial class Form1
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
            cmbControlType = new ComboBox();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // cmbControlType
            // 
            cmbControlType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbControlType.FormattingEnabled = true;
            cmbControlType.Items.AddRange(new object[] { "TextBox", "CheckBox", "Button" });
            cmbControlType.Location = new Point(14, 16);
            cmbControlType.Margin = new Padding(4, 4, 4, 4);
            cmbControlType.Name = "cmbControlType";
            cmbControlType.Size = new Size(471, 25);
            cmbControlType.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(14, 51);
            btnGenerate.Margin = new Padding(4, 4, 4, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(471, 30);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate Control";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(633, 341);
            Controls.Add(btnGenerate);
            Controls.Add(cmbControlType);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Dynamic Controls App";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbControlType;
        private Button btnGenerate;
    }
}
