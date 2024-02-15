internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snakes and Ladders: Extra!");
        Console.WriteLine("Press the Ready button when you are ready to play.");

        string playerOneName = GetPlayerOneName();
    }

    public static string GetPlayerOneName()
    {
        Console.WriteLine("Select a letter for Player 1: A, B, C or D.")

        string[] validPlayerOneName = new [] {"A", "B", "C", "D"};
        string playerOneName;

        do
        {
            playerOneName = Console.ReadLine().ToUpper();

            if (!validPlayerOneName.Contains(playerOneName));
            {
                Console.WriteLine("That's not valid. Try again.");
            }
        }
        while (!validPlayerOneName.Contains(playerOneName));
        return playerOneName
    }



}