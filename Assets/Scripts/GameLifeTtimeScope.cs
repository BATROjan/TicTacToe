using DefaultNamespace.Grid;
using DefaultNamespace.Grid.Cell;
using DefaultNamespace.Piece;
using UI;
using UI.MainMenuUIWindow;
using UI.UIRoot;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class GameLifeTtimeScope: LifetimeScope
    {
        [SerializeField] private UIRootView _uiRootView;
        [SerializeField] private CellView _cellView;
        [SerializeField] private GridView _gridView;
        [SerializeField] private PieceView _pieceView;
        
        [SerializeField] private UIRootConfig _uiRootConfig;
        [SerializeField] private CellConfig _cellConfig;
        [SerializeField] private GridConfig _gridConfig;

        protected override void Configure(IContainerBuilder builder)
        {
            //Service
            builder.Register<IGridController, GridController>(Lifetime.Scoped);
            builder.Register<ICellController, CellController>(Lifetime.Scoped);
            builder.Register<IPieceController, PieceController>(Lifetime.Scoped);

            //Views
            builder.RegisterComponentInNewPrefab(_uiRootView, Lifetime.Scoped).AsImplementedInterfaces();
            builder.RegisterComponentInNewPrefab(_gridView, Lifetime.Scoped);
            builder.RegisterComponent(_cellView);
            builder.RegisterComponent(_pieceView);

            //Configs
            builder.RegisterInstance(_uiRootConfig);
            builder.RegisterInstance(_cellConfig);
            builder.RegisterInstance(_gridConfig);
        
            //Controllers
            builder.RegisterEntryPoint<GameController>();
            builder.RegisterEntryPoint<UIRootController>();
            
            //Factories
            builder.Register<UIFactory>(Lifetime.Scoped).AsSelf().As<IUIFactory>();
            builder.Register<CellFactory>(Lifetime.Scoped).AsSelf().As<ICellFactory>();
            builder.Register<PieceFactory>(Lifetime.Scoped).AsSelf().As<IPieceFactory>();
        }
    }
}