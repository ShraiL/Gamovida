// LashaMurgvaLominadzeShraieri.Quiz3.Services/SqlPersonService.cs
using LashaMurgvaLominadzeShraieri.Quiz3.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace LashaMurgvaLominadzeShraieri.Quiz3.Services
{
    public class SqlPersonService
    {
        private readonly string _connectionString;

        public SqlPersonService()
        {
            // IMPORTANT: Replace "YourStrongPassword123!" with the actual password you used
            // If you named your SQL Server container differently, adjust 'Server' accordingly.
            _connectionString = "Server=localhost,1433;Database=UG;User Id=sa;Password=YourPassword123;TrustServerCertificate=True;";
        }

        public void AddPerson(Person person)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO People (Firstname, Lastname, Email, Gender, Age) VALUES (@Firstname, @Lastname, @Email, @Gender, @Age)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Firstname", person.Name);
                    command.Parameters.AddWithValue("@Lastname", person.Lastname);
                    command.Parameters.AddWithValue("@Email", person.Email);
                    command.Parameters.AddWithValue("@Gender", person.Gender.ToString()); // Store enum as string
                    command.Parameters.AddWithValue("@Age", person.Age);
                    command.ExecuteNonQuery(); // Execute the INSERT statement
                }
            }
        }

        public void DeletePerson(int id) // Changed from index to ID for database operations
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM People WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePerson(Person updatedPerson) // Takes Person object, not index
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "UPDATE People SET Firstname = @Firstname, Lastname = @Lastname, Email = @Email, Gender = @Gender, Age = @Age WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Firstname", updatedPerson.Name);
                    command.Parameters.AddWithValue("@Lastname", updatedPerson.Lastname);
                    command.Parameters.AddWithValue("@Email", updatedPerson.Email);
                    command.Parameters.AddWithValue("@Gender", updatedPerson.Gender.ToString());
                    command.Parameters.AddWithValue("@Age", updatedPerson.Age);
                    command.Parameters.AddWithValue("@Id", updatedPerson.ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT Id, Firstname, Lastname, Email, Gender, Age FROM People";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Convert gender string from DB back to Gender enum
                            Gender gender;
                            Enum.TryParse(reader["Gender"].ToString(), out gender);

                            people.Add(new Person(
                                name: reader["Firstname"].ToString(),
                                lastname: reader["Lastname"].ToString(),
                                email: reader["Email"].ToString(),
                                gender: gender,
                                age: (int)reader["Age"]
                            )
                            { ID = (int)reader["Id"] }); // Assign the ID from the database
                        }
                    }
                }
            }
            return people;
        }
    }
}
