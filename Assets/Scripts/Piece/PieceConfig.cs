using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.Piece
{
    [CreateAssetMenu(fileName = "PieceConfig", menuName = "configs/PieceConfig")]

    public class PieceConfig : ScriptableObject
    {
        [SerializeField] private PieceModel[] _pieceModel;
        
        private Dictionary<PieceType, PieceModel> _viewsDictionary;

        public PieceModel GetModelByType(PieceType type)
        {
            Init();
            return _viewsDictionary[type];
        }

        public Dictionary<PieceType, PieceModel> GetDictionaryModels()
        {
            return _viewsDictionary;
        }
        private void Init()
        {
            if (_viewsDictionary == null)
            {
                _viewsDictionary = new();
                foreach (var model in _pieceModel)
                {
                    _viewsDictionary.Add(model.PieceType, model);
                }
            }
        }
    }
    
    [Serializable]
    public struct PieceModel
    {
        public PieceType PieceType;
        public Sprite Sprite;
    }
    public enum PieceType
    {
        Tic,
        Tac
    }
}