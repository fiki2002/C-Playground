using Courses.Course;
using There.Student;
using Tosin.Lecturer;

namespace Lmao.Department
{
        public class Department
        {
                public int DepartmentId { get; set; }
                public string Name { get; set; }
                public int FacultyId { get; set; }
                public List<Lecturer> Lecturers { get; set; }
                public List<Student> Students { get; set; }
                public List<Course> Courses { get; set; }

                private void AssignResources()
                {
                        Console.WriteLine($"Assigning resources to department: {Name}");
                }

                public void DisplayDepartmentInfo()
                {
                        Console.WriteLine($"Department ID: {DepartmentId}, Name: {Name}, Faculty ID: {FacultyId}");
                }
        }


}