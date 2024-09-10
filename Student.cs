using Courses.Course;

namespace There.Student
{
        public class Student
        {
                public int StudentId { get; set; }
                public string Name { get; set; }
                public int DepartmentId { get; set; }
                public int FacultyId { get; set; }
                public List<Course> EnrolledCourses { get; set; }

                private void StudyForExam()
                {
                        Console.WriteLine($"Student {Name} is studying for an exam");
                }

                public void DisplayStudentInfo()
                {
                        Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Department ID: {DepartmentId}, Faculty ID: {FacultyId}");
                }
        }
}