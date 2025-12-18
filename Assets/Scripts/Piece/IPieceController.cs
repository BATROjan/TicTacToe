using UnityEngine;

namespace DefaultNamespace.Piece
{
    public interface IPieceController
    {
        PieceView SpawnView(PieceType type, Transform transform);
        void DespawnView(PieceView view);
    }
}