using KChess.Enums;
using System;

namespace KChess
{
    public class Game
    {
        private const int BOARD_SIZE = 8;

        private Square[][] board;

        public Game()
        {
            this.board = CreateBoard();
        }

        public Square GetSquare(string coordinate)
        {
            if (string.IsNullOrEmpty(coordinate) || coordinate.Length > 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            int file = GetFile(coordinate);
            int rank = GetRank(coordinate);

            return board[file][rank];
        }

        private Square[][] CreateBoard()
        {
            Square[][] board = new Square[BOARD_SIZE][];

            for (int i = 0; i < BOARD_SIZE; i += 1)
            {
                Square[] rank = new Square[BOARD_SIZE];
                for (int j = 0; j < BOARD_SIZE; j += 1)
                {
                    rank[j] = new Square(GetSquareColor(i, j));
                }
                board[i] = rank;
            }

            return board;
        }

        private static Color GetSquareColor(int i, int j)
        {
            if ((i + j) % 2 != 0) return Color.White;

            return Color.Black;
        }

        private static int GetFile(string coordinate)
        {
            char x = coordinate.ToLower()[0];

            switch (x)
            {
                case 'a':return 0;
                case 'b':return 1;
                case 'c':return 2;
                case 'd':return 3;
                case 'e':return 4;
                case 'f':return 5;
                case 'g':return 6;
                case 'h':return 7;
            }

            throw new ArgumentOutOfRangeException();
        }

        private static int GetRank(string coordinate)
        {
            int y = (int) char.GetNumericValue(coordinate[1]);
            
            if (y > BOARD_SIZE) throw new ArgumentOutOfRangeException();

            return y - 1;
        }
    }
}
