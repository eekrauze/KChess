using KChess.Enums;

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
