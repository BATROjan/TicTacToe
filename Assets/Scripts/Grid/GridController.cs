using System.Collections.Generic;
using DefaultNamespace.Grid.Cell;
using UnityEngine;

namespace DefaultNamespace.Grid
{
    public class GridController : IGridController
    {
        private readonly GridView _gridView;
        private readonly GridConfig _gridConfig;
        private readonly ICellController _cellController;

        private List<CellView> _cellViews = new();
        public GridController(
            GridView gridView,
            GridConfig gridConfig,
            ICellController cellController
            )
        {
            _gridView = gridView;
            _gridConfig = gridConfig;
            _cellController = cellController;
        }

        public void SpawnGrid()
        {
            var gridModel = _gridConfig.GetGridByType(GridType.Default);
            var xSpawnPoint = (gridModel.HorizontalCount - 1) * gridModel.offset / 2;
            var ySpawnPoint = (gridModel.VerticalCount - 1) * gridModel.offset / 2;
            Vector3 spawnPosition = new Vector3(-xSpawnPoint, -ySpawnPoint, 0);
            
            for (int i = 0; i < gridModel.HorizontalCount; i++)
            {
                for (int g = 0; g < gridModel.VerticalCount; g++)
                {
                    Vector3 currentPosition = new Vector3(spawnPosition.x+i*gridModel.offset, spawnPosition.y+g*gridModel.offset, 0);

                   var view = _cellController.SpawnCell(CellType.Default, _gridView.transform, currentPosition);
                   _cellViews.Add(view);
                }
            }
        }
    }
}