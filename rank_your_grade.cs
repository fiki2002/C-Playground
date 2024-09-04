
// Console.WriteLine("Welcome to CGPAme");


// Console.WriteLine("Here we take in your grades and output your CGPA");


// Console.WriteLine("But before we proceed, let's know the total number of courses you are doing");


namespace DeyPlay
{

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student> {
               new Student{Id= 1, FullName=  "Tosin"},
               new Student{Id= 2, FullName= "Timi"},
               new Student{Id= 3,FullName= "Tope"},
               new Student{Id= 4,  FullName= "Bayo"},
               new Student{Id= 5, FullName="Sola"},
               new Student{Id= 6,FullName= "Bimpe"},
               new Student{Id= 7,FullName= "Femi"},
               new Student{Id= 8,FullName= "Ayo"},
               new Student{Id= 9, FullName="Mubaraq"},
               new Student{Id= 0,FullName= "Tola"},
            };



            List<StudentRecord> listOfRecords = new List<StudentRecord> {
              new  StudentRecord{ StudentId = 1,EnglishScore =  40,MathsScore= 70 },
              new  StudentRecord{ StudentId = 2, EnglishScore =  50, MathsScore= 30 },
              new  StudentRecord{ StudentId = 3,EnglishScore =  65,MathsScore= 99 },
              new  StudentRecord{ StudentId = 4, EnglishScore = 20,MathsScore= 0 },
              new  StudentRecord{ StudentId = 5,EnglishScore =  35,MathsScore= 69 },
              new  StudentRecord{ StudentId = 6,EnglishScore =  20,MathsScore= 33 },
              new  StudentRecord{ StudentId = 7, EnglishScore = 5, MathsScore=10 },
              new  StudentRecord{ StudentId = 8, EnglishScore = 98,MathsScore= 100 },
              new  StudentRecord{ StudentId = 9,EnglishScore =  50,MathsScore= 46 },
              new  StudentRecord{ StudentId = 0, EnglishScore = 100,MathsScore= 100 },
            };

            foreach (var student in students)
            {
                /// This 
                /// listOfRecords.Where(r => r.StudentId == student.Id)
                /// returns the list of student record that matches with the student's id,
                /// but since there'd only be one of that on the list, we do .FirstOrDefault
                var studentRecord = listOfRecords.Where(r => r.StudentId == student.Id).FirstOrDefault();

                if (studentRecord != null)
                {
                    Console.WriteLine($"Student: {student.FullName} (ID: {student.Id})");
                    Console.WriteLine($"English Score: {studentRecord.EnglishScore}, Maths Score: {studentRecord.MathsScore}");
                    Console.WriteLine();
                }
            }
        }
    }
}
public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
}

public class StudentRecord
{
    public int StudentId { get; set; }
    public int EnglishScore { get; set; }
    public int MathsScore { get; set; }
}


