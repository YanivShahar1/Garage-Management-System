using System;
using System.Windows.Forms;

namespace GarageUI
{
    public class FormValidator
    {
        public static bool IsNotEmptyTextBox(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{fieldName} cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool IsNumericComboBoxItemSelected(ComboBox comboBox, string fieldName)
        {
            if (!int.TryParse(comboBox.SelectedItem?.ToString(), out _))
            {
                MessageBox.Show($"Invalid {fieldName}. Please select a valid {fieldName}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Add more validation methods as needed...
    }
}
