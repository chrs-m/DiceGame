int playerOneRandomNr;
int playerTwoRandomNr;
int playerOneScore = 0;
int playerTwoScore = 0;

Random random = new Random();

var numOfRounds = 0;

System.Console.WriteLine("This is dice game, you'll play ten rounds.");

do
{

    System.Console.WriteLine("Press any key to roll the dice.");

    Console.ReadKey();

    playerOneRandomNr = random.Next(1, 7);
    System.Console.WriteLine("You rolled a " + playerOneRandomNr);

    playerTwoRandomNr = random.Next(1, 7);
    System.Console.WriteLine("Computer rolled a " + playerTwoRandomNr);


    if (playerOneRandomNr > playerTwoRandomNr)
    {
        System.Console.WriteLine("You won! \n");
        playerOneScore++;
    }
    if (playerTwoRandomNr > playerOneRandomNr)
    {
        System.Console.WriteLine("Computer won, you lost! \n");
        playerTwoScore++;
    }

    if (playerOneRandomNr == playerTwoRandomNr)
    {
        System.Console.WriteLine("Draw! What are the odds of that? \n");
    }

    numOfRounds++;
} while (numOfRounds < 10);

System.Console.WriteLine("End of game!");
Console.WriteLine($"Final score is: You({playerOneScore}) - Computer({playerTwoScore})");