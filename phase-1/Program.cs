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
    //Int.Parse has to be used with userInput due to ReadLine() ALWAYS being a string
    //Int.Parse converts it into a number or int (integer)
    string userInput = Console.ReadLine();
    int Guess = int.Parse(userInput);

    //Display the user's guess back to the screen
    // Console.WriteLine("You guessed:" + Guess); <--- Phase 2 said to comment this out --->


        //Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number
  int secretNumber = 42;
  
    //Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message
  if (Guess == secretNumber) {

    Console.Write("How did you know?!? Do you peek at my cheat sheet?");
  } else {
    Console.Write("Wow! You guessed... oh... So close!");
  }
}
}