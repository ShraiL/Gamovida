using LashaMurgvaLominadzeShraieri.Quiz3.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LashaMurgvaLominadzeShraieri.Quiz3
{
    public partial class UserDialog : Form
    {
        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }
        public Gender Gender { get; private set; }
        public int Age { get; private set; }

        public UserDialog()
        {
            InitializeComponent();

            // Populate the GenderComboBox with Gender enum values
            GenderComboBox.Items.AddRange(Enum.GetValues(typeof(Gender)).Cast<Gender>().Cast<object>().ToArray());
        }

        public UserDialog(Person person) : this()
        {
            NameTextBox.Text = person.Name;
            LastnameTextBox.Text = person.Lastname;
            EmailTextBox.Text = person.Email;
            GenderComboBox.SelectedItem = person.Gender;  // Make sure this correctly sets the selected item
            AgeTextBox.Text = person.Age.ToString();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            // Ensure the fields are populated correctly
            Name = NameTextBox.Text;
            Lastname = LastnameTextBox.Text;
            Email = EmailTextBox.Text;

            // Ensure the Gender ComboBox has a valid selected item
            if (GenderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Gender = (Gender)GenderComboBox.SelectedItem;

            // Validate the Age field
            if (!int.TryParse(AgeTextBox.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Age = age;

            // Close the dialog after validation
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
