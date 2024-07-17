using System;


partial class Program 
{
  static void Main() 
  {
    //Display a message asking the user to guess the number
    Console.WriteLine("Can you guess the secret number???");

    //Display a prompt for the user's guess
    Console.Write("Enter your guess here:");

    //Take the user's guess as input and save it as a variable
    string userInput = Console.ReadLine();
    int Guess = int.Parse(userInput);

    //Display the user's guess back to the screen
    Console.WriteLine("You guessed:" + Guess);
  }
}