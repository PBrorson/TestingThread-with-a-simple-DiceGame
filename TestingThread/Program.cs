int playerRandomNum;
int enemyRandomNum;

int playerPoints = 0;
int enemyPoints = 0;

Random random = new Random();

// Loop 10 times
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any key to roll the dice."); // Displays message asking player to press any key

    Console.ReadKey(); // Waits for the player to press any key before generating number

    playerRandomNum = random.Next(1, 7); 
    Console.WriteLine("You rolled a " + playerRandomNum); 

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000); 

    enemyRandomNum = random.Next(1, 7); 
    Console.WriteLine("Enemy AI rolled a " + enemyRandomNum); 

    // If the player rolls higher than enemy
    if (playerRandomNum > enemyRandomNum)
    {
        playerPoints++; // Increase player points
        Console.WriteLine("Player wins this round!"); // Display message saying player has won this round
    }
    else if (playerRandomNum < enemyRandomNum) // If the enemy rolls higher than player
    {
        enemyPoints++; // Increase enemy points
        Console.WriteLine("Enemy wins this round!"); // Display message saying enemy has won this round
    }
    else 
    {
        Console.WriteLine("Draw!"); 

    // Displays player and enemy scores
    Console.WriteLine("The score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
    Console.WriteLine(); 
}


if (playerPoints > enemyPoints)
{
    Console.WriteLine("You win!"); 
}
else if (playerPoints < enemyPoints) 
{
    Console.WriteLine("You lose!"); 
}
else 
{
    Console.WriteLine("It's a draw!");
}

Console.ReadKey(); 

