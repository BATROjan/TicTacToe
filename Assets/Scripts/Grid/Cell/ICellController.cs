using UnityEngine;

namespace DefaultNamespace.Grid.Cell
{
    public interface ICellController
    {
        CellView SpawnCell(CellType type, Transform transform, Vector3 position);
        void DespawnCell(CellView cellView);
        void ActivateCell(CellView cellView);
        void DiactivateCell(CellView cellView);
    }
}