Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}
bool ShouldPlay()
{
    string userInput = Console.ReadLine();

    if (userInput == "Y") { return true; }
    else if (userInput == "N") { return false; }
    else
    {
        Console.WriteLine("Enter the valid Option!.");
        return ShouldPlay();
    }
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}
string WinOrLose(int val1, int val2)
{
    if (val2 > val1)
    {
        return "You win!";
    }
    else
    {
        return "You lose!";
    }
}