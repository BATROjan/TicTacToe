using DefaultNamespace.Grid;
using DefaultNamespace.Grid.Cell;
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
        
        [SerializeField] private UIRootConfig _uiRootConfig;
        [SerializeField] private CellConfig _cellConfig;
        [SerializeField] private GridConfig _gridConfig;

        protected override void Configure(IContainerBuilder builder)
        {
            //Service
            builder.Register<IGridController, GridController>(Lifetime.Scoped);
            builder.Register<ICellController, CellController>(Lifetime.Scoped);

            //Views
            builder.RegisterComponentInNewPrefab(_uiRootView, Lifetime.Scoped).AsImplementedInterfaces();
            builder.RegisterComponentInNewPrefab(_gridView, Lifetime.Scoped);
            builder.RegisterComponent(_cellView);

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
        }
    }
}