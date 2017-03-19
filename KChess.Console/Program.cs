using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KChess.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Game.Name);
            System.Console.WriteLine(Game.GetSquareColor("a3"));
            System.Console.WriteLine(Game.GetSquareColor("b5"));
            System.Console.WriteLine(Game.GetSquareColor("f6"));
            System.Console.WriteLine(Game.GetSquareColor("h5"));
            System.Console.ReadKey();
        }
    }
}
