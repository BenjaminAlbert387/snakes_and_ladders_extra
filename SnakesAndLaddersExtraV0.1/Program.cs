using System;
class SnakesAndLaddersExtra
{
    static void Main(string[] args)
    {
        const int player3position = 0;
        const int player4position = 0;

        int position3 = player3position;
        int position4 = player4position;

        Console.WriteLine("Welcome to Snakes and Ladders v0.1");

        while (position3 <= 50 || position4 <= 50);
        {
            Console.WriteLine($"\nCurrent position of Player 3: {position3}");

            Console.WriteLine("Rolling dice...");

        int playerThreeDice;

        Thread.Sleep(3000);

        Random random = new Random();

        playerThreeDice = random.Next(1, 7);
        Console.WriteLine("Player 1 rolled a " + playerThreeDice);

        p1_position += playerOneDice;

        Console.WriteLine($"Current postition: {position3}");

        }

    }
}