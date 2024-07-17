using System;

partial class Program 
{
    static void Main() 
    {
        Console.WriteLine("Select difficulty level (Easy/Medium/Hard/Cheater)");
        string difficulty = Console.ReadLine().ToLower();

        int attempts = difficulty switch {
            "easy" => 8,
            "medium" => 6,
            "hard" => 4,
            "cheater" => int.MaxValue, // Allows for infinite times until input is correct answer
            _ => 4
        };

        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        Console.WriteLine("Can you guess the secret number???");

        for (int i = 0; i < attempts; i++) 
        {
            if (difficulty != "cheater") 
            {
                Console.Write($"Your guess ({i + 1}), {attempts - i} attempts left: ");
            } 
            else 
            {
                Console.Write("Your guess: ");
            }

            int Guess = int.Parse(Console.ReadLine());

            if (Guess == secretNumber) 
            {
                Console.WriteLine("How did you know?!? Do you peek at my cheat sheet?");
                return;
            } 
            else if (Guess > secretNumber) 
            {
                Console.WriteLine("Woah, that's a little too high!");
            } 
            else 
            {
                Console.WriteLine("Gotta go a little higher then that!");
            }

            if (difficulty == "cheater") 
            {
                i--; // Prevent the index from increasing
            }
        }

        // If the loop ends without a correct guess, inform the user they are out of attempts
        if (difficulty != "cheater") 
        {
            Console.WriteLine("You are out of attempts The super secret number was " + secretNumber);
        }
    }
}
