using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.Grid
{
    [CreateAssetMenu(fileName = "GridConfig", menuName = "configs/GridConfig")]
    public class GridConfig: ScriptableObject
    {
        [SerializeField] private GridModel[] _gridModels;
        
        private Dictionary<GridType, GridModel> _viewsDictionary;

        public GridModel GetGridByType(GridType type)
        {
            Init();
            return _viewsDictionary[type];
        }
        private void Init()
        {
            if (_viewsDictionary == null)
            {
                _viewsDictionary = new();
                foreach (var model in _gridModels)
                {
                    _viewsDictionary.Add(model.GridType, model);
                }
            }
        }
    }
    
    [Serializable]
    public struct GridModel
    {
        public GridType GridType;
        public int VerticalCount;
        public int HorizontalCount;
        public float offset;
    }

    public enum GridType
    {
        Default
    }
}