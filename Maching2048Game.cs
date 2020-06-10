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



        