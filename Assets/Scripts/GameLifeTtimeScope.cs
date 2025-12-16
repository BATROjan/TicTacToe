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
        [SerializeField] private UIRootConfig _uiRootConfig;

        protected override void Configure(IContainerBuilder builder)
        {
            //Service

            //Views
            builder.RegisterComponentInNewPrefab(_uiRootView, Lifetime.Scoped).AsImplementedInterfaces();
        
            //Configs
            builder.RegisterInstance(_uiRootConfig);
        
            //Controllers
            builder.RegisterEntryPoint<GameController>();
            builder.RegisterEntryPoint<UIRootController>();
            
            //Factories
            builder.Register<UIFactory>(Lifetime.Scoped).AsSelf().As<IUIFactory>();
        }
    }
}