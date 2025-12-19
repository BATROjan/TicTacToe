using UnityEngine;

namespace DefaultNamespace.Piece
{
    public interface IPieceFactory
    {
        PieceView CreateCellView(ProjectConst.PieceType type, Transform transform);

    }
}