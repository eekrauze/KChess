﻿namespace KChess
{
    public class Game
    {
        public static string Name = "KChess";

        public static int GetSquareColor(string coordinate)
        {
            int x = GetX(coordinate);
            int y = GetY(coordinate);

            if ((x + y) % 2 != 0) return 0;

            return 1;
        }

        public static bool IsBlack(string coordinate)
        {
            return GetSquareColor(coordinate) == 1;
        }


        public static bool IsWhite(string coordinate)
        {
            return GetSquareColor(coordinate) == 0;
        }

        private static int GetX(string coordinate)
        {
            char x = coordinate[0];

            switch (x)
            {
                case 'a': return 1;
                case 'b': return 2;
                case 'c': return 3;
                case 'd': return 4;
                case 'e': return 5;
                case 'f': return 6;
                case 'g': return 7;
                case 'h': return 8;
            }

            return -1;
        }

        private static int GetY(string coordinate)
        {
            int y = (int) char.GetNumericValue(coordinate[1]);
            return y;
        }
    }
}
