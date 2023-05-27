using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HRManagementSystem
{
    public partial class EmployeeCreationForm : Form
    {
        private Dictionary<string, List<string>> citiesByCountry;

        public EmployeeCreationForm()
        {
            InitializeComponent();

            // Initialize the dictionary with cities by country
            citiesByCountry = new Dictionary<string, List<string>>();
            citiesByCountry.Add("UAE", new List<string> { "DUBAI", "ABODABI", "ALSHARIKA" });
            citiesByCountry.Add("SAUDI ARABIA", new List<string> { "ALRYAD", "JADDA", "ALMADINA-ALMONAWARA" });
            citiesByCountry.Add("OTHER", new List<string> { "ALDAWHA", "MASQAT", "ALKWAIT" });

            // Populate the country combobox
            cmbCountry.Items.AddRange(citiesByCountry.Keys.ToArray());

            // Set the default selected country
            cmbCountry.SelectedIndex = 0;

            // Update the city combobox based on the selected country
            UpdateCityComboBox();
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the city combobox based on the selected country
            UpdateCityComboBox();
        }

        private void UpdateCityComboBox()
        {
            // Clear the city combobox
            cmbCity.Items.Clear();

            // Get the selected country
            string selectedCountry = cmbCountry.SelectedItem.ToString();

            // Check if the selected country exists in the dictionary
            if (citiesByCountry.ContainsKey(selectedCountry))
            {
                // Populate the city combobox with the cities of the selected country
                cmbCity.Items.AddRange(citiesByCountry[selectedCountry].ToArray());
            }

            // Set the default selected city
            if (cmbCity.Items.Count > 0)
            {
                cmbCity.SelectedIndex = 0;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Get the input values from the form
            string nationalNumber = txtNationalNumber.Text;
            string fullName = txtFullName.Text;
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string country = cmbCountry.SelectedItem.ToString();
            string city = cmbCity.SelectedItem.ToString();
            string gender = rbtnMale.Checked ? "Male" : "Female";

            // Get the selected skills
            List<string> skills = new List<string>();
            if (chkProgramming.Checked)
            {
                skills.Add("Programming");
            }
            if (chkWebDesign.Checked)
            {
                skills.Add("Web Design");
            }
            if (chkUIUX.Checked)
            {
                skills.Add("UI/UX");
            }

            // Create a new employee object
            Employee newEmployee = new Employee(nationalNumber, fullName, dateOfBirth, country, city, gender, skills);

            // Print the employee information
            string summaryMessage = $"Employee added:\n" +
                $"National Number: {newEmployee.NationalNumber}\n" +
                $"Full Name: {newEmployee.FullName}\n" +
                $"Date of Birth: {newEmployee.DateOfBirth.ToShortDateString()}\n" +
                $"Country: {newEmployee.Country}\n" +
                $"City: {newEmployee.City}\n" +
                $"Gender: {newEmployee.Gender}\n" +
                $"Skills: {string.Join(", ", newEmployee.Skills)}";

            MessageBox.Show(summaryMessage, "Employee Added");

            // Clear the form fields
            ClearFormFields();
        }

        private void ClearFormFields()
        {
            txtNationalNumber.Clear();
            txtFullName.Clear();
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-22); // Set default date of birth to 22 years ago
            cmbCountry.SelectedIndex = 0;
            UpdateCityComboBox();
            rbtnMale.Checked = true;
            chkProgramming.Checked = false;
            chkWebDesign.Checked = false;
            chkUIUX.Checked = false;
        }
    }

    public class Employee
    {
        public string NationalNumber { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public List<string> Skills { get; set; }

        public Employee(string nationalNumber, string fullName, DateTime dateOfBirth, string country, string city, string gender, List<string> skills)
        {
            NationalNumber = nationalNumber;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Country = country;
            City = city;
            Gender = gender;
            Skills = skills;
        }
    }
}
