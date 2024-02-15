//to run the code, type in dotnet run

//Benjamin's code starts here
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snakes and Ladders: Extra!");
        Console.WriteLine("Press the Ready button when you are ready to play.");

        string playerOneName = GetPlayerOneName();
        string playerTwoName = GetPlayerTwoName();
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
// Benjamin's code ends here
}