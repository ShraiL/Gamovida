// LashaMurgvaLominadzeShraieri.Quiz3.Models/Person.cs
namespace LashaMurgvaLominadzeShraieri.Quiz3.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Person
    {
        // Remove _nextId, as the database will handle ID generation
        public int ID { get; set; } // Make ID settable
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public Person(string name, string lastname, string email, Gender gender, int age)
        {
            // Do not set ID here; it will be assigned by the database on insert
            Name = name;
            Lastname = lastname;
            Email = email;
            Gender = gender;
            Age = age;
        }

        // Add a default constructor for scenarios where you might instantiate
        // a Person object and then set its properties individually (e.g., when reading from DB).
        public Person() { }

        // Basic email validation method (unchanged)
        public bool IsEmailValid()
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(Email);
                return mailAddress.Address == Email;
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{ID} {Name} {Lastname}";
        }
    }
}
