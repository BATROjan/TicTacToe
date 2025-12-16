using DefaultNamespace;
using UI;
using UI.MainMenuUIWindow;
using UI.UIRoot;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class MainMenuLifetimeScope : LifetimeScope
{
    [SerializeField] private UIRootView _uiRootView;
    [SerializeField] private UIRootConfig _uiRootConfig;
    
    protected override void Configure(IContainerBuilder builder)
    {
        //Service

        //Views
        builder.RegisterComponent(_uiRootView).As<IUIRootView>();
        
        //Configs
        builder.RegisterInstance(_uiRootConfig);
        
        //Controllers
        builder.RegisterEntryPoint<MainMenuWindowUIController>();
        builder.RegisterEntryPoint<UIRootController>();

        //Factories
        builder.Register<UIFactory>(Lifetime.Scoped).AsSelf().As<IUIFactory>();
    }
}