using System;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using VContainer.Unity;
using IInitializable = VContainer.Unity.IInitializable;

namespace UI.UIRoot
{
    public class UIRootController : IUIRootController, IDisposable, IStartable
    {
        private readonly IUIRootView _uiRootView;
        private readonly UIFactory _uiFactory;
        private readonly UIRootConfig _uiRootConfig;
        private Dictionary<UIWindowType, BaseUIWindowView> _dictionaryViews = new();
        public UIRootController(
            IUIRootView uiRootView, 
            UIFactory uiFactory,
            UIRootConfig uiRootConfig
           )
        {
            _uiRootView = uiRootView;
            _uiFactory = uiFactory;
            _uiRootConfig = uiRootConfig;
            
            _dictionaryViews = _uiFactory.CreateAll(_uiRootView.DiactivateContainer);
            Debug.Log("UIRoot Created");
        }
        public void Start()
        {
            ShowWindow(UIWindowType.MainMenu);
        }
        
        public BaseUIWindowView SpawnWindow(UIWindowType type)
        {
            BaseUIWindowView view =  _uiFactory.Create(type, _uiRootView.DiactivateContainer);
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
            view.OnHided?.Invoke(view);
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