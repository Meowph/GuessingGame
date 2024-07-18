// Phase 1
// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.

// Phase 2
// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.

// Phase 3
// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2

// Phase 4
// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.

// Phase 5
// Use a random number between 1 and 100 instead of a hard-coded number.
// The prompt should display the number of guesses the user has left.

// Phase 6
// Inform the user if their guess was too high or too low, when they guess incorrectly.

// Phase 7
// Prompt the user for a difficulty level before they are prompted to guess the number.
// The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
// Easy - this gives the user eight guesses.
// Medium - this gives the user six guesses.
// Hard - this gives the user four guesses.

// Phase 8
// Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.


// using System;
// using System.Security.Cryptography;


// partial class Program 
// {
//   static void Main() 
//   {

//     //Prompt the user for a difficulty level before they are prompted to guess the number
//     //Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct
//   Console.WriteLine("Select difficulty level (Easy/Medium/Hard/Cheater)");
//   string difficulty = Console.ReadLine().ToLower();

//        //Give the user four chances to guess the number.
//     int attempts = difficulty switch {
//       "Easy" => 8,
//       "Medium" => 6,
//       "Hard" => 4,
//       "Cheater" => int.MaxValue, //allows for infinite times until input is correct answer
//        _ => 4
//     };

//     //Use a random number between 1 and 100 instead of a hard-coded number
//     //Number was hard-coded as 42
//   Random random = new Random();
//   int secretNumber = random.Next(1,100);


//     //Display a message asking the user to guess the number
//     Console.WriteLine("Can you guess the secret number???");

//     //Loop continues until all 4 attempts are use. Program is exited after 4th guess 
//     for (int i = 0; i < attempts; i++) {

//     //Display a prompt for the user's guess
//     // Console.WriteLine("Enter your guess here:");

//     //Take the user's guess as input and save it as a variable
//     //Int.Parse has to be used with userInput due to ReadLine() ALWAYS being a string
//     //Int.Parse converts it into a number or int (integer)
//     // string userInput = Console.ReadLine(); <--- replaced by int Guess = int.Parse(Console.ReadLine()); --->

//     if (difficulty != "Cheater") {

//     //Prompt displays the number of guesses the user has left
//     Console.Write($"Your Guesses ({attempts - i} attempts left:)");

//     } else {

//        Console.Write("Your guess: ");

//     }

//     int Guess = int.Parse(Console.ReadLine());
    

//     //Display the user's guess back to the screen
//     // Console.WriteLine("You guessed:" + Guess); <--- Phase 2 said to comment this out --->
  
//     //Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message
//   if (Guess == secretNumber) {

//     Console.WriteLine("How did you know?!? Do you peek at my cheat sheet?");
//     //ends the loop when correct number is guessed
//     return;

//     //Inform the user if their guess was too high or too low, when they guess incorrectly
//   } else if (Guess > secretNumber){

//     Console.WriteLine("Woah, that's a little too high!");

//   } else {

//     Console.WriteLine("Gotta go a little higher then that!");
//   }

//   if (difficulty == "Cheater") {
//     i--; //Amount of attempts will not be displayed
//   }
// }
//  // If the loop ends without a correct guess, inform the user they are out of attempts
//         Console.WriteLine("Sorry, you have run out of attempts. The secret number was " + secretNumber);
// }
// }