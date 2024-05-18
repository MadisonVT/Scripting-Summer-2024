using System;
//Required for program to work.
namespace MyApplication
//Required.
{
  class Program
  //Required.
  {
    static void Main(string[] args)
    //Main function. Takes args that were pre-inputed by W3.
    {
      string User_Name = Console.ReadLine();
      //Asks user for their name.
      Console.WriteLine("Welcome " + User_Name + "!");
      //Writes their name to the console with a welcome message.
      int Cool_Num = 14;
      //Testing a number variable
      float Float_Num = 2.0f;
      //Testing a float variable
      bool Bool_Var = true;
      //Testing a boolean variable
      string String_Var = "Cool Numbers and Variables!";
      //Testing a string variable
      int Cooler_Num = Cool_Num / 2;
      //Dividing the number variable by 2
      Console.WriteLine(String_Var);
      //Writes a message to the console
      Console.WriteLine(Cooler_Num);
      //Writes quotient to the console.
      Console.WriteLine(Float_Num);
      //Writes a float to the console.
      Console.WriteLine(Bool_Var);
      //Writes the boolean value to the console.
     }
  }
}
