// to run the code in terminal:
// type in cd SnakesAndLaddersExtra
// type in dotnet run

//Benjamin's code starts here
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snakes and Ladders: Extra!");
        Console.WriteLine("Press the Ready button when you are ready to play.");

        string playerOneName = GetPlayerOneName();
        string playerTwoName = GetPlayerTwoName();
        int playerOneDice = GetPlayerOneDice();
        int playerTwoDice = GetPlayerTwoDice();
        GetPlayerOneDice();
        GetPlayerTwoDice();
    }

    public static string GetPlayerOneName()
    {
        Console.WriteLine("Select a letter for Player 1: A, B, C or D.");

        string[] validPlayerOneName = new [] {"A", "B", "C", "D"};
        string playerOneName;

        do
        {
            playerOneName = Console.ReadLine().ToUpper();

            if (!validPlayerOneName.Contains(playerOneName))
            {
                Console.WriteLine("That's not valid. Try again.");
            }
        }
        while (!validPlayerOneName.Contains(playerOneName));
        return playerOneName;
    }

    public static string GetPlayerTwoName()
    {
        Console.WriteLine("Select a letter for Player 2: E, F, G or H.");

        string[] validPlayerTwoName = new [] {"E", "F", "G", "H"};
        string playerTwoName;

        do
        {
            playerTwoName = Console.ReadLine().ToUpper();

            if (!validPlayerTwoName.Contains(playerTwoName))
            {
                Console.WriteLine("That's not valid. Try again.");
            }
        }
        while (!validPlayerTwoName.Contains(playerTwoName));
        return playerTwoName;
    }

// Simulates a dice roll for Player 1
    public static int GetPlayerOneDice()
    {
        const int P1_POSITION = 0;
        int p1_position = P1_POSITION;

        Console.WriteLine($"Current postition: {p1_position}");

        Console.WriteLine("Rolling dice...");

        Thread.Sleep(3000);

        int playerOneDice;

        Random random = new Random();

        playerOneDice = random.Next(1, 7);
        Console.WriteLine("Player 1 rolled a " + playerOneDice);

        p1_position += playerOneDice;

        Console.WriteLine($"Current postition: {p1_position}");

        return playerOneDice;
    }

// Simulates a dice roll for Player 2
    public static int GetPlayerTwoDice()
    {
        const int P2_POSITION = 0;
        int p2_position = P2_POSITION;

        Console.WriteLine($"Current postition: {p2_position}");

        Console.WriteLine("Rolling dice...");

        Thread.Sleep(3000);

        int playerTwoDice;

        Random random = new Random();

        playerTwoDice = random.Next(1, 7);
        Console.WriteLine("Player 2 rolled a " + playerTwoDice);

        p2_position += playerTwoDice;

        Console.WriteLine($"Current postition: {p2_position}");

        return playerTwoDice;
    }

// Benjamin's code ends here
}