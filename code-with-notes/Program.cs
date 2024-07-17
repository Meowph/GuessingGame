using System;


partial class Program 
{
  static void Main() 
  {

    //Use a random number between 1 and 100 instead of a hard-coded number
    //Number was hard-coded as 42
  Random random = new Random();
  int secretNumber = random.Next(1,100);

    //Give the user four chances to guess the number.
    int attempts = 4;

    //Display a message asking the user to guess the number
    Console.WriteLine("Can you guess the secret number???");

    //Loop continues until all 4 attempts are use. Program is exited after 4th guess 
    for (int i = 0; i < attempts; i++) {

    //Display a prompt for the user's guess
    // Console.WriteLine("Enter your guess here:");

    //Take the user's guess as input and save it as a variable
    //Int.Parse has to be used with userInput due to ReadLine() ALWAYS being a string
    //Int.Parse converts it into a number or int (integer)
    // string userInput = Console.ReadLine(); <--- replaced by int Guess = int.Parse(Console.ReadLine()); --->

    //Prompt displays the number of guesses the user has left
    Console.Write($"Your Guesses ({attempts - i} attempts left:)");
    int Guess = int.Parse(Console.ReadLine());

    //Display the user's guess back to the screen
    // Console.WriteLine("You guessed:" + Guess); <--- Phase 2 said to comment this out --->
  
    //Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message
  if (Guess == secretNumber) {

    Console.WriteLine("How did you know?!? Do you peek at my cheat sheet?");
    //ends the loop when correct number is guessed
    return;

  } else {

    Console.WriteLine("Wow! You guessed... oh... So close! Try again?");
  }
}
}
}