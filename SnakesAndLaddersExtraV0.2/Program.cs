using System;
class SnakesAndLaddersExtra
{
    static void Main(string[] args)
    {
        int player3position = 0;
        int player4position = 0;

        int position3 = player3position;
        int position4 = player4position;

        Console.WriteLine("Welcome to Snakes and Ladders v0.1");

        while (position3 <= 50 || position4 <= 50);
        {
            Console.WriteLine("\nPress Enter to play (or 'Q' to quit):");
            //if (Console.ReadLine().ToUpper() == "Q")
                //break;

            Console.WriteLine($"\nCurrent position of Player 3: {position3}");
            Console.WriteLine("Rolling dice...");
            int playerThreeDice;
            Thread.Sleep(1000);

            Random p3dice = new Random();
            playerThreeDice = p3dice.Next(1, 7);
            Console.WriteLine("Player 3 rolled a " + playerThreeDice);

            position3 += playerThreeDice;

            Console.WriteLine($"New postition of Player 3: {position3}");

            /**/
            Console.WriteLine($"\nCurrent position of Player 4: {position4}");
            Console.WriteLine("Rolling dice...");
            int playerFourDice;
            Thread.Sleep(1000);

            Random p4dice = new Random();
            playerFourDice = p4dice.Next(1, 7);
            Console.WriteLine("Player 4 rolled a " + playerFourDice);

            position4 += playerFourDice;

            Console.WriteLine($"New postition of Player 4: {position4}");
        }
        Console.WriteLine("\nGame over! Thanks for playing!");
    }
}