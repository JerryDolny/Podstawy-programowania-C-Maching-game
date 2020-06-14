namespace Kfl.Maching2048Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
        }
    }

    class Game
    {
        public ulong Score { get; private set; }
        public ulong[,] Board { get; private set; }

        private readonly int nRows;
        private readonly int nCols;
        private readonly Random random = new Random();

        public Game()
        {
            this.Board = new ulong[4, 4];
            this.nRows = this.Board.GetLength(0);
            this.nCols = this.Board.GetLength(1);
            this.Score = 0;
            //TEST GIT Desctop app branch 1
            //Test G 2 
            //Test G 3
            //Test G 4
        }

        public void Run()
        {
            bool hasUpdated = true;
            do
            {
                if (hasUpdated)
                {
                    PutNewValue();
                }

                Display();

                if (IsDead())
                {
                    using (new ColorOutput(ConsoleColor.Red))
                    {
                        Console.WriteLine("YOU ARE DEAD!!!");
                        break;
                    }
                }

                Console.WriteLine("Use arrow keys to move the tiles. Press Ctrl-C to exit.");
                ConsoleKeyInfo input = Console.ReadKey(true); 
                Console.WriteLine(input.Key.ToString());

                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        hasUpdated = Update(Direction.Up);
                        break;

                    case ConsoleKey.DownArrow:
                        hasUpdated = Update(Direction.Down);
                        break;

                    case ConsoleKey.LeftArrow:
                        hasUpdated = Update(Direction.Left);
                        break;

                    case ConsoleKey.RightArrow:
                        hasUpdated = Update(Direction.Right);
                        break;

                    default:
                        hasUpdated = false;
                        break;
                }
            }
            while (true); 

            Console.WriteLine("Press any key to quit...");
            Console.Read();
        }
        