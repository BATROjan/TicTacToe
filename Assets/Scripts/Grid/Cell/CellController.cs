using UnityEngine;

namespace DefaultNamespace.Grid.Cell
{
    public class CellController: ICellController
    {
        private readonly CellFactory _cellFactory;

        public CellController(CellFactory cellFactory)
        {
            _cellFactory = cellFactory;
        }

        public CellView SpawnCell(CellType type, Transform transform, Vector3 position)
        {
            var view = _cellFactory.CreateCellView(type, transform, position);
            return view;
        }

        public void DespawnCell(CellView cellView)
        {
        }

        public void ActivateCell(CellView cellView)
        {
        }

        public void DiactivateCell(CellView cellView)
        {
        }
    }
}