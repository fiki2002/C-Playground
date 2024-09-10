

using Lmao.Department;

public class Faculty
{
        public int FacultyId { get; set; }
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        private void UpdateFacultyRecords()
        {
                Console.WriteLine($"Updating records for faculty: {Name}");
        }

        public void DisplayFacultyInfo()
        {
                Console.WriteLine($"Faculty ID: {FacultyId}, Name: {Name}");
        }
}