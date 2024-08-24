Console.WriteLine("******* Welcome to RankYourGrade *******");
Console.WriteLine(" ");
Console.WriteLine("Input your score to get a grade!");

string? scoreInputted = Console.ReadLine();

        if (int.TryParse(scoreInputted, out int scoreInInteger))
        {
            string grade;

            if (scoreInInteger >= 70 && scoreInInteger <= 100)
            {
                grade = "A";
            }
            else if (scoreInInteger >= 60 && scoreInInteger <= 69)
            {
                grade = "B";
            }
            else if (scoreInInteger >= 50 && scoreInInteger <= 59)
            {
                grade = "C";
            }
            else if (scoreInInteger >= 40 && scoreInInteger <= 49)
            {
                grade = "D";
            }
            else if (scoreInInteger >= 0 && scoreInInteger <= 39)
            {
                grade = "F";
            }
            else
            {
                Console.WriteLine($"{scoreInInteger} was invalid, accepted range is 0 - 100");
                return;
            }

            Console.WriteLine($"Oh, you had {scoreInInteger}");
            Console.Write("Your grade is: ");
            Console.WriteLine(grade);
        }
        else
        {
            Console.WriteLine($"{scoreInputted} is not a valid number.");
        }