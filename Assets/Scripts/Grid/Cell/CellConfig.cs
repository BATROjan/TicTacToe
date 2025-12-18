using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace DefaultNamespace.Grid.Cell
{
    
    [CreateAssetMenu(fileName = "CellConfig", menuName = "configs/CellConfig")]
    public class CellConfig : ScriptableObject
    {
        [SerializeField] private CellModel[] _cellModels;
        
        private Dictionary<CellType, CellModel> _viewsDictionary;

        public CellModel GetCellByType(CellType type)
        {
            Init();
            return _viewsDictionary[type];
        }
        
        private void Init()
        {
            if (_viewsDictionary == null)
            {
                _viewsDictionary = new();
                foreach (var model in _cellModels)
                {
                    _viewsDictionary.Add(model.CellType, model);
                }
            }
        }
    }
    
    [Serializable]
    public struct CellModel
    {
        public CellType CellType;
        public Sprite Sprite;
    }
    public enum CellType
    {
        Default
    }
}