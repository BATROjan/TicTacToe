using System;
using System.Collections.Generic;
using DefaultNamespace;

namespace UI.UIRoot
{
    public class UIRootController : IUIRootController, IDisposable
    {
        private readonly IUIRootView _uiRootView;
        private readonly UIFactory _uiFactory;
        private readonly UIRootConfig _uiRootConfig;
        private Dictionary<UIWindowType, BaseUIWindowView> _dictionaryViews = new();
        public UIRootController(
            IUIRootView uiRootView, 
            UIRootConfig uiRootConfig,
            UIFactory uiFactory
           )
        {
            _uiRootView = uiRootView;
            _uiFactory = uiFactory;
            _uiRootConfig = uiRootConfig;
        }
        public void Start()
        {
            _dictionaryViews = _uiFactory.CreateAll(_uiRootView.DiactivateContainer);//перекинуть в метод старт и создавать нужные

            ShowWindow(UIWindowType.MainMenu);
        }

        public BaseUIWindowView SpawnWindow(UIWindowType type)
        {
            BaseUIWindowView view =  _uiFactory.CreateWindow(type, _uiRootView.DiactivateContainer);
            return view;
        }

        public void ShowWindow(UIWindowType type)
        {
            var view = _dictionaryViews[type];
            view.transform.SetParent(_uiRootView.ActivateContainer);
            view.Show();
        }

        public void HideWindow(UIWindowType type)
        {
            var view = _dictionaryViews[type];
            view.transform.SetParent(_uiRootView.DiactivateContainer);
            view.Hide();
        }

        public BaseUIWindowView GetWindow(UIWindowType type)
        {
            var view = _dictionaryViews[type];
            return view;
        }


        public void Dispose()
        {
        }


    }
}