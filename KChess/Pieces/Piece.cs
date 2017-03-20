using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KChess.Pieces
{
    public abstract class Piece
    {
        public Color Color { get; }

        public Piece(Color color)
        {
            this.Color = color;
        }

//        public abstract void Move();
    }
}
