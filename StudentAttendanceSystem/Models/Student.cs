namespace StudentAttendanceSystem.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}