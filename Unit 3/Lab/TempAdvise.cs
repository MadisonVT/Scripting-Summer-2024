using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            Console.WriteLine("What is the temperature in Celsius right now?");
            //Prompts user for a temperature in Celsius.
            int temp;
            //Creates an empty int variable.
            temp = Convert.ToInt32(Console.ReadLine());
            //Assigns an int user input to the int "temp" variable.
            string result = (temp > 30) ? "Stay in the shade and drink plenty of water!" : "Enjoy the nice weather!";
            //If statement with a different message depending on wether the input is above or below 30.
            Console.WriteLine(result);
            //Prints the result of the If statement to the console.
        }
    }
}
