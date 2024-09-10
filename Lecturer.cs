using Courses.Course;

namespace Tosin.Lecturer
{
        public class Lecturer
        {

                public int LecturerId { get; set; }
                public string Name { get; set; }
                public int DepartmentId { get; set; }
                public List<Course> CoursesTaught { get; set; }

                private void PrepareLecture()
                {
                        Console.WriteLine($"Lecturer {Name} is preparing a lecture");
                }

                public void DisplayLecturerInfo()
                {
                        Console.WriteLine($"Lecturer ID: {LecturerId}, Name: {Name}, Department ID: {DepartmentId}");
                }
        }
}