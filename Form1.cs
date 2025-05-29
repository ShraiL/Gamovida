// LashaMurgvaLominadzeShraieri.Quiz3/Form1.cs
using LashaMurgvaLominadzeShraieri.Quiz3.Models;
using LashaMurgvaLominadzeShraieri.Quiz3.Services;
using System.ComponentModel; // Make sure this is included

namespace LashaMurgvaLominadzeShraieri.Quiz3
{
    public partial class Form1 : Form
    {
        // Change from PersonService to SqlPersonService
        private readonly SqlPersonService _personService;
        private readonly BindingList<Person> _bindingList;

        public Form1()
        {
            InitializeComponent();
            _personService = new SqlPersonService(); // Instantiate the new service
            _bindingList = new BindingList<Person>();
            listBox.DataSource = _bindingList;
            listBox.DisplayMember = "ToString"; // Display the ToString() output in the ListBox

            Sync(); // Load initial data from the database when the form loads
        }

        // Add Button Click Event
        private void addBtn_Click(object sender, EventArgs e)
        {
            UserDialog dialog = new UserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var person = new Person(
                    dialog.Name,
                    dialog.Lastname,
                    dialog.Email,
                    dialog.Gender,
                    dialog.Age
                );

                _personService.AddPerson(person);
                Sync(); // Update the list
            }
        }

        // Edit Button Click Event
        private void editBtn_Click(object sender, EventArgs e)
        {
            // Get the selected Person object directly from the ListBox
            if (listBox.SelectedItem is Person selectedPerson)
            {
                UserDialog dialog = new UserDialog(selectedPerson);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Update the properties of the selectedPerson object
                    selectedPerson.Name = dialog.Name;
                    selectedPerson.Lastname = dialog.Lastname;
                    selectedPerson.Email = dialog.Email;
                    selectedPerson.Gender = dialog.Gender;
                    selectedPerson.Age = dialog.Age;

                    // Pass the updated Person object to the service
                    _personService.UpdatePerson(selectedPerson);
                    Sync(); // Update the list
                }
            }
            else
            {
                MessageBox.Show("Please select a person to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Delete Button Click Event
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Get the selected Person object directly from the ListBox
            if (listBox.SelectedItem is Person selectedPerson)
            {
                // Pass the ID of the selected Person to the service for deletion
                _personService.DeletePerson(selectedPerson.ID);
                Sync(); // Update the list
            }
            else
            {
                MessageBox.Show("Please select a person to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sync the list with updated data
        private void Sync()
        {
            _bindingList.Clear(); // Clear current list
            var people = _personService.GetPeople().ToList(); // Get updated people from service
            foreach (var person in people)
            {
                _bindingList.Add(person); // Add each person to the BindingList
            }
        }
    }
}
