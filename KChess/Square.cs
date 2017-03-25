using KChess.Pieces;
using KChess.Enums;

namespace KChess
{
    public class Square
    {
        public Piece Piece { get; set; }
        public Color Color { get; private set; }

        public bool IsEmpty
        {
            get { return this.Piece == null; }
        }

        public bool IsWhite
        {
            get { return this.Color == Color.White; }
        }

        public bool IsBlack
        {
            get { return this.Color == Color.Black; }
        }

        public Square(Color color)
        {
            this.Color = color;
        }

        public Square(Color color, Piece piece) : this(color)
        {
            this.Piece = piece;
        }
    }
}
