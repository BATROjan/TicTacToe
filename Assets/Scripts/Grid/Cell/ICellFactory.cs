using UnityEngine;

namespace DefaultNamespace.Grid.Cell
{
    public interface ICellFactory
    {
        CellView CreateCellView(CellType type, Transform transform, Vector3 position);
    }
}