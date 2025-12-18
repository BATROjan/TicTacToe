using UnityEngine;

namespace DefaultNamespace.Piece
{
    public interface IPieceFactory
    {
        PieceView CreateCellView(PieceType type, Transform transform);

    }
}