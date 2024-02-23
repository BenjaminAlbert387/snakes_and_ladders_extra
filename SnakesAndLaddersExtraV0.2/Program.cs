// to run the code in terminal:
// type in cd SnakesAndLaddersExtraV0.2
// type in dotnet run

//Benjamin's code starts here

using System;
class SnakesAndLaddersExtra
{
    static void Main(string[] args)
    {
        const int player3position = 0;
        const int player4position = 0;

        int position3 = player3position;
        int position4 = player4position;

        Console.WriteLine("Welcome to Snakes and Ladders v0.2");

        while (position3 <= 50 && position4 <= 50)
        {
            if (position3 >= 50)
            {
                Console.WriteLine("\nPlayer 3 wins!");
                break;
            }

            if (position4 >= 50)
            {
                Console.WriteLine("\nPlayer 4 wins!");
                break;
            }

            Console.WriteLine("\nPress Enter to roll dice. Type 'Q' to quit. ");
            if (Console.ReadLine().ToUpper() == "Q")
                break;

            Console.WriteLine($"\nCurrent position of Player 3: {position3}");
            Console.WriteLine("Rolling dice...");
            int playerThreeDice;
            Thread.Sleep(100);

            Random p3dice = new Random();
            playerThreeDice = p3dice.Next(1, 7);
            Console.WriteLine("Player 3 rolled a " + playerThreeDice);

            position3 += playerThreeDice;

            Console.WriteLine($"New postition of Player 3: {position3}");

            /**/
            Console.WriteLine($"\nCurrent position of Player 4: {position4}");
            Console.WriteLine("Rolling dice...");
            int playerFourDice;
            Thread.Sleep(100);

            Random p4dice = new Random();
            playerFourDice = p4dice.Next(1, 7);
            Console.WriteLine("Player 4 rolled a " + playerFourDice);

            position4 += playerFourDice;

            Console.WriteLine($"New postition of Player 4: {position4}");
        }
    }
}
// and ends here