using Courses.Course;
using Lmao.Department;
using There.Student;
using Tosin.Lecturer;

public class Program
{

    public static void Main(string[] args)
    {
        Faculty scienceFaculty = new Faculty { FacultyId = 1, Name = "Faculty of Science" };
        Faculty artsFaculty = new Faculty { FacultyId = 2, Name = "Faculty of Arts" };
        Faculty engineeringFaculty = new Faculty { FacultyId = 3, Name = "Faculty of Engineering" };

        Department computerScience = new Department { DepartmentId = 1, Name = "Computer Science", FacultyId = 1 };
        Department literature = new Department { DepartmentId = 2, Name = "Literature", FacultyId = 2 };
        Department mechanicalEngineering = new Department { DepartmentId = 3, Name = "Mechanical Engineering", FacultyId = 3 };

        Lecturer drSmith = new Lecturer { LecturerId = 1, Name = "Dr. Smith", DepartmentId = 1 };
        Lecturer profJohnson = new Lecturer { LecturerId = 2, Name = "Prof. Johnson", DepartmentId = 2 };
        Lecturer drBrown = new Lecturer { LecturerId = 3, Name = "Dr. Brown", DepartmentId = 3 };

        Student johnDoe = new Student { StudentId = 1, Name = "John Doe", DepartmentId = 1, FacultyId = 1 };
        Student janeSmith = new Student { StudentId = 2, Name = "Jane Smith", DepartmentId = 2, FacultyId = 2 };
        Student bobWilson = new Student { StudentId = 3, Name = "Bob Wilson", DepartmentId = 3, FacultyId = 3 };

        Course programmingCourse = new Course { CourseId = 1, Name = "Introduction to Programming", DepartmentId = 1, LecturerId = 1 };
        Course shakespeareCourse = new Course { CourseId = 2, Name = "Shakespeare's Plays", DepartmentId = 2, LecturerId = 2 };
        Course thermodynamicsCourse = new Course { CourseId = 3, Name = "Thermodynamics", DepartmentId = 3, LecturerId = 3 };

        scienceFaculty.DisplayFacultyInfo();
        computerScience.DisplayDepartmentInfo();
        drSmith.DisplayLecturerInfo();
        johnDoe.DisplayStudentInfo();
        programmingCourse.DisplayCourseInfo();
    }
}