using NumberGame;

try
{
    Console.WriteLine("Guess a number: ");
    var guess = Convert.ToInt32(Console.ReadLine());
    var result = new NumberGame.NumberGame(new Die()).RateGuess(guess);
    Console.WriteLine($"You scored {result} points!");
}
catch (Exception)
{
    Console.WriteLine("You did not enter a valid number!");
}
