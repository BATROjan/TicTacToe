using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace DefaultNamespace.Grid.Cell
{
    public class CellFactory: ICellFactory
    {
        private readonly CellView _cellView;
        private readonly IObjectResolver _resolver;
        private readonly CellConfig _cellConfig;
        
        public CellFactory(
           CellView cellView,
            IObjectResolver resolver, 
            CellConfig cellConfig)
        {
            _cellView = cellView;
            _resolver = resolver;
            _cellConfig = cellConfig;
        }
        
        public CellView CreateCellView(CellType type, Transform transform, Vector3 position)
        {
            var model = _cellConfig.GetCellByType(type);
            CellView view = _resolver.Instantiate(_cellView);
            view.SpriteRenderer.sprite = model.Sprite;
            view.transform.SetParent(transform);
            view.transform.position = position;
            
            return view;
        }
    }
}