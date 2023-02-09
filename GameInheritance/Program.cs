using System;
using System.Transactions;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a game");
        String game1 = Console.ReadLine();
        Console.WriteLine("Enter max number of players");
        int numOfPlayers1 = Convert.ToInt32(Console.ReadLine());

        // game with no time limit
        Game g1 = new Game(game1, numOfPlayers1);

        Console.WriteLine("Enter a game with time limit");
        String game2 = Console.ReadLine();
        Console.WriteLine("Enter max number of players");
        int numOfPlayers2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the time limit in minutes");
        int timeLimit = Convert.ToInt32(Console.ReadLine());

        // game with time limit
        Game g2 = new GameWithTimeLimit(game2, numOfPlayers2, timeLimit);


        // Output
        Console.WriteLine(g1);
        Console.WriteLine(g2);
    }

    class Game
    {
        public String name;
        public int numOfPlayers;
        public Game(String name, int numOfPlayers)
        {
            this.name = name;
            this.numOfPlayers = numOfPlayers;
        }

        public override string ToString()
        {
            String s = "Maximum number of players for " + this.name + $" is {numOfPlayers}";
            return s;
        }
    }

    class GameWithTimeLimit : Game
    {
        public int timeLimit;

        public GameWithTimeLimit(String name, int numOfPlayers, int timeLimit) : base(name,numOfPlayers)
        {
            this.timeLimit = timeLimit;
        }

        public override string ToString()
        {
            String str = base.ToString();
            str = str + '\n' + "Time Limit for Football is " + timeLimit + " minutes";

            return str;
        }
    }
}
