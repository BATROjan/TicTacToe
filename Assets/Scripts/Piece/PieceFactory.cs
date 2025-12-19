using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace DefaultNamespace.Piece
{
    public class PieceFactory : IPieceFactory
    {
        private readonly PieceView _pieceView;
        private readonly IObjectResolver _resolver;
        private readonly PieceConfig _pieceConfig;
        
        private Dictionary<ProjectConst.PieceType, PieceModel> _dictionaryViews;

        public PieceFactory(
            PieceView pieceView,
            IObjectResolver resolver, 
            PieceConfig pieceConfig)
        {
            _pieceView = pieceView;
            _resolver = resolver;
            _pieceConfig = pieceConfig;

            _dictionaryViews = _pieceConfig.GetDictionaryModels();
        }
        
        public PieceView CreateCellView(ProjectConst.PieceType type, Transform transform)
        {
            PieceView view = _resolver.Instantiate(_pieceView);
            view.transform.SetParent(transform, false);
            view.Type = type;
            view.SpriteRenderer.sprite = _dictionaryViews[type].Sprite;
            
            return view;
        }
    }
}