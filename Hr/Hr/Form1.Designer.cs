namespace HRManagementSystem
{
    partial class EmployeeCreationForm
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
            txtNationalNumber = new TextBox();
            lblNationalNumber = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblDateOfBirth = new Label();
            dtpDateOfBirth = new DateTimePicker();
            cmbCountry = new ComboBox();
            lblCountry = new Label();
            lblCity = new Label();
            cmbCity = new ComboBox();
            grpGender = new GroupBox();
            rbtnFemale = new RadioButton();
            rbtnMale = new RadioButton();
            grpSkills = new GroupBox();
            chkUIUX = new CheckBox();
            chkWebDesign = new CheckBox();
            chkProgramming = new CheckBox();
            btnAddEmployee = new Button();
            grpGender.SuspendLayout();
            grpSkills.SuspendLayout();
            SuspendLayout();
            // 
            // txtNationalNumber
            // 
            txtNationalNumber.Location = new Point(172, 29);
            txtNationalNumber.Name = "txtNationalNumber";
            txtNationalNumber.Size = new Size(200, 25);
            txtNationalNumber.TabIndex = 0;
            // 
            // lblNationalNumber
            // 
            lblNationalNumber.AutoSize = true;
            lblNationalNumber.Location = new Point(25, 33);
            lblNationalNumber.Name = "lblNationalNumber";
            lblNationalNumber.Size = new Size(112, 17);
            lblNationalNumber.TabIndex = 1;
            lblNationalNumber.Text = "National Number:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(25, 73);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(69, 17);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(172, 69);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 25);
            txtFullName.TabIndex = 2;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(25, 112);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(84, 17);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(172, 107);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 25);
            dtpDateOfBirth.TabIndex = 6;
            // 
            // cmbCountry
            // 
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(172, 148);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(200, 25);
            cmbCountry.TabIndex = 7;
            cmbCountry.SelectedIndexChanged += cmbCountry_SelectedIndexChanged;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(25, 152);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(56, 17);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Country:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(25, 192);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(32, 17);
            lblCity.TabIndex = 9;
            lblCity.Text = "City:";
            // 
            // cmbCity
            // 
            cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(172, 188);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(200, 25);
            cmbCity.TabIndex = 10;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbtnFemale);
            grpGender.Controls.Add(rbtnMale);
            grpGender.Location = new Point(28, 232);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(344, 68);
            grpGender.TabIndex = 11;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(150, 28);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(67, 21);
            rbtnFemale.TabIndex = 1;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(26, 28);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(55, 21);
            rbtnMale.TabIndex = 0;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // grpSkills
            // 
            grpSkills.Controls.Add(chkUIUX);
            grpSkills.Controls.Add(chkWebDesign);
            grpSkills.Controls.Add(chkProgramming);
            grpSkills.Location = new Point(28, 320);
            grpSkills.Name = "grpSkills";
            grpSkills.Size = new Size(344, 107);
            grpSkills.TabIndex = 12;
            grpSkills.TabStop = false;
            grpSkills.Text = "Skills (IT)";
            // 
            // chkUIUX
            // 
            chkUIUX.AutoSize = true;
            chkUIUX.Location = new Point(26, 69);
            chkUIUX.Name = "chkUIUX";
            chkUIUX.Size = new Size(61, 21);
            chkUIUX.TabIndex = 2;
            chkUIUX.Text = "UI/UX";
            chkUIUX.UseVisualStyleBackColor = true;
            // 
            // chkWebDesign
            // 
            chkWebDesign.AutoSize = true;
            chkWebDesign.Location = new Point(26, 46);
            chkWebDesign.Name = "chkWebDesign";
            chkWebDesign.Size = new Size(97, 21);
            chkWebDesign.TabIndex = 1;
            chkWebDesign.Text = "Web Design";
            chkWebDesign.UseVisualStyleBackColor = true;
            // 
            // chkProgramming
            // 
            chkProgramming.AutoSize = true;
            chkProgramming.Location = new Point(26, 24);
            chkProgramming.Name = "chkProgramming";
            chkProgramming.Size = new Size(107, 21);
            chkProgramming.TabIndex = 0;
            chkProgramming.Text = "Programming";
            chkProgramming.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(172, 449);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(100, 34);
            btnAddEmployee.TabIndex = 13;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // EmployeeCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(606, 510);
            Controls.Add(btnAddEmployee);
            Controls.Add(grpSkills);
            Controls.Add(grpGender);
            Controls.Add(cmbCity);
            Controls.Add(lblCity);
            Controls.Add(lblCountry);
            Controls.Add(cmbCountry);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblNationalNumber);
            Controls.Add(txtNationalNumber);
            Name = "EmployeeCreationForm";
            Text = "Employee Creation Form";
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            grpSkills.ResumeLayout(false);
            grpSkills.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNationalNumber;
        private Label lblNationalNumber;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cmbCountry;
        private Label lblCountry;
        private Label lblCity;
        private ComboBox cmbCity;
        private GroupBox grpGender;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private GroupBox grpSkills;
        private CheckBox chkUIUX;
        private CheckBox chkWebDesign;
        private CheckBox chkProgramming;
        private Button btnAddEmployee;
    }
}
