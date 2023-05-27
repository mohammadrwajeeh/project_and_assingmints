namespace zxxz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateControls = new Button();
            comControlType = new ComboBox();
            lblContorlType = new Label();
            lblNumberOfControls = new Label();
            txtNumOfControls = new TextBox();
            pnlDynamicControls = new Panel();
            SuspendLayout();
            // 
            // btnCreateControls
            // 
            btnCreateControls.Location = new Point(543, 61);
            btnCreateControls.Name = "btnCreateControls";
            btnCreateControls.Size = new Size(180, 29);
            btnCreateControls.TabIndex = 0;
            btnCreateControls.Text = "Create Controls";
            btnCreateControls.UseVisualStyleBackColor = true;
            btnCreateControls.Click += btnCreateControls_Click;
            // 
            // comControlType
            // 
            comControlType.FormattingEnabled = true;
            comControlType.Items.AddRange(new object[] { "Button", "TextBox", "Label" });
            comControlType.Location = new Point(326, 29);
            comControlType.Name = "comControlType";
            comControlType.Size = new Size(185, 28);
            comControlType.TabIndex = 1;
            // 
            // lblContorlType
            // 
            lblContorlType.AutoSize = true;
            lblContorlType.Location = new Point(210, 37);
            lblContorlType.Name = "lblContorlType";
            lblContorlType.Size = new Size(91, 20);
            lblContorlType.TabIndex = 2;
            lblContorlType.Text = "Control type";
            // 
            // lblNumberOfControls
            // 
            lblNumberOfControls.AutoSize = true;
            lblNumberOfControls.Location = new Point(179, 99);
            lblNumberOfControls.Name = "lblNumberOfControls";
            lblNumberOfControls.Size = new Size(142, 20);
            lblNumberOfControls.TabIndex = 3;
            lblNumberOfControls.Text = "Number Of Controls";
            // 
            // txtNumOfControls
            // 
            txtNumOfControls.Location = new Point(337, 92);
            txtNumOfControls.Name = "txtNumOfControls";
            txtNumOfControls.Size = new Size(174, 27);
            txtNumOfControls.TabIndex = 4;
            // 
            // pnlDynamicControls
            // 
            pnlDynamicControls.Location = new Point(12, 150);
            pnlDynamicControls.Name = "pnlDynamicControls";
            pnlDynamicControls.Size = new Size(751, 288);
            pnlDynamicControls.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDynamicControls);
            Controls.Add(txtNumOfControls);
            Controls.Add(lblNumberOfControls);
            Controls.Add(lblContorlType);
            Controls.Add(comControlType);
            Controls.Add(btnCreateControls);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateControls;
        private ComboBox comControlType;
        private Label lblContorlType;
        private Label lblNumberOfControls;
        private TextBox txtNumOfControls;
        private Panel pnlDynamicControls;
    }
}