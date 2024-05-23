using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            Console.WriteLine("What is your exam score as a percentage?");
            //Writes a prompt to the console for the user.
            int grade;
            //Empty "grade" variable created.
            grade = Convert.ToInt32(Console.ReadLine());
            //Sets the "grade" variable to whatever the user types (int).
            if (grade >= 90 && grade <= 100)
            //Checks if "grade" is between 90 and 100 percent.
            {
                Console.WriteLine("A");
                Console.WriteLine("Great Job!");
                //Writes "A" to console and a message for the user.
            }
            else if (grade >= 80 && grade <= 89)
            //Checks if "grade" is between 80 and 89 percent.
            {
                Console.WriteLine("B");
                Console.WriteLine("Good Job!");
                //Writes "B" to console and a message for the user.
            }
            else if (grade >= 70 && grade <= 79)
            //Checks if "grade" is between 70 and 79 percent.
            {
                Console.WriteLine("C");
                Console.WriteLine("Decent!");
                //Writes "C" to console and a message for the user.
            }
            else if (grade >= 60 && grade <= 69)
            //Checks if "grade" is between 60 and 69 percent.
            {
                Console.WriteLine("D");
                Console.WriteLine("Could be better.");
                //Writes "D" to console and a message for the user.
            }
            else if (grade >= 0 && grade <= 59)
            //Checks if "grade" is between 0 and 59 percent.
            {
                Console.WriteLine("F");
                Console.WriteLine("Needs Work!");
                //Writes "F" to console and a message for the user.
            }
            else
            {
                Console.WriteLine("Invalid. Please convert your score to a percentage.");
                //Tells the user that their input is invalid (not a number or not a percentage).
            }
        }
    }
}
