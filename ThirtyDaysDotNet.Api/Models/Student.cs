
using System.ComponentModel.DataAnnotations;

namespace ThirtyDaysDotNet.Api.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Student name is required")]
        [MinLength(3, ErrorMessage = "Name must contain at least 3 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [RegularExpression(
            @"^[a-z0-9]+@gmail\.com$",
            ErrorMessage = "Email must contain lowercase letters or numbers and end with @gmail.com")]
        public string Email { get; set; } = string.Empty;

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }
    }
}

