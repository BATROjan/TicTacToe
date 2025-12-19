using DefaultNamespace.Grid;
using DefaultNamespace.InputController;
using DefaultNamespace.Piece;
using UI.MainMenuUIWindow;
using UI.UIRoot;
using UniRx;
using UnityEngine;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class GameController: IStartable
    {
        private readonly IPieceController _pieceController;
        private readonly MouseInputController _inputController;
        private readonly IGridController _gridController;
        private readonly IUIRootController _uiRootController;

        private CompositeDisposable _disposable = new();
        private UIRootView _uiRootView;

        public GameController(
            IPieceController pieceController,
            MouseInputController inputController,
            IGridController gridController,
            IUIRootController uiRootController)
        {
            _pieceController = pieceController;
            _inputController = inputController;
            _gridController = gridController;
            _uiRootController = uiRootController;
            
        }
        
        public void Start()
        {
            Debug.Log("GameController is started");
            _gridController.SpawnGrid();
            _inputController
                .OnMouseButtonPressed
                .Subscribe(x => SpawnPiece(x))
                .AddTo(_disposable);
        }

        public void SpawnPiece(Transform transform)
        {
            _pieceController.SpawnView(ProjectConst.PieceType.Tic, transform);
        }
    }
}