using There.Student;

namespace Courses.Course
{
        public class Course
        {
                public int CourseId { get; set; }
                public string Name { get; set; }
                public int DepartmentId { get; set; }
                public int LecturerId { get; set; }
                public List<Student> EnrolledStudents { get; set; }

                private void UpdateCourseContent()
                {
                        Console.WriteLine($"Updating content for course: {Name}");
                }

                public void DisplayCourseInfo()
                {
                        Console.WriteLine($"Course ID: {CourseId}, Name: {Name}, Department ID: {DepartmentId}, Lecturer ID: {LecturerId}");
                }
        }
}