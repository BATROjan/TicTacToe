using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.Piece
{
    public class PieceController: IPieceController
    {
        private readonly IPieceFactory _pieceFactory;
        private List<PieceView> _pieceViewList = new ();
        
        public PieceController(
            IPieceFactory pieceFactory)
        {
            _pieceFactory = pieceFactory;
        }

        public PieceView SpawnView(PieceType type, Transform transform)
        {
            var view = _pieceFactory.CreateCellView(type, transform);
            _pieceViewList.Add(view);
            
            return view;
        }

        public void DespawnView(PieceView view)
        {
        }
    }
}