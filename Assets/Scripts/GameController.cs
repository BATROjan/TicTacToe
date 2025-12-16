using UI.MainMenuUIWindow;
using UI.UIRoot;
using UnityEngine;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class GameController: IStartable
    {
        private readonly IUIRootController _uiRootController;
        private UIRootView _uiRootView;

        public GameController(IUIRootController uiRootController)
        {
            _uiRootController = uiRootController;
        }
        
        public void Start()
        {
            Debug.Log("GameController is started");
        }
    }
}