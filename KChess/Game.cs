using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KChess
{
    public class Game
    {
        public static string Name = "KChess";

        public static int GetSquareColor(string squareName)
        {
            int x = GetX(squareName);
            int y = GetY(squareName);

            if (x % 2 == 0 && y % 2 != 0 || x % 2 != 0 && y % 2 == 0) return 0;

            return 1;
        }

        private static int GetX(string squareName)
        {
            char x = squareName[0];

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

        private static int GetY(string squareName)
        {
            int y = (int)Char.GetNumericValue(squareName[1]);
            return y;
        }
    }
}
