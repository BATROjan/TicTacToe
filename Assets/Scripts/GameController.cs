using DefaultNamespace.Grid;
using UI.MainMenuUIWindow;
using UI.UIRoot;
using UnityEngine;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class GameController: IStartable
    {
        private readonly IGridController _gridController;
        private readonly IUIRootController _uiRootController;
        private UIRootView _uiRootView;

        public GameController(
            IGridController gridController,
            IUIRootController uiRootController)
        {
            _gridController = gridController;
            _uiRootController = uiRootController;
        }
        
        public void Start()
        {
            Debug.Log("GameController is started");
            _gridController.SpawnGrid();
        }
    }
}