using System;

namespace KChess.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Game.Name);

            try
            {
                System.Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                System.Console.WriteLine();
            }
        }
    }
}
