using System;
using System.Collections.Generic;
using UI;
using UI.UIRoot;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class UIFactory : IUIFactory
    {
        private readonly IObjectResolver _resolver;
        private readonly UIRootConfig _uiRootConfig;

        private Dictionary<UIWindowType, BaseUIWindowView> _dictionaryViews = new();
        private Dictionary<UIWindowType, BaseUIWindowView> _allDictionaryViews = new();
        
        public UIFactory(IObjectResolver resolver, UIRootConfig uiRootConfig)
        {
            _resolver = resolver;
            _uiRootConfig = uiRootConfig;
            
            _dictionaryViews = _uiRootConfig.GetDictionaryVies();
        }


        public BaseUIWindowView Create(UIWindowType type, Transform transform)
        {
            if (!_dictionaryViews.TryGetValue(type, out BaseUIWindowView prefab))
            {
                Debug.LogError($"[UnitViewFactory] No prefab registered for UnitType: {type}");
                return null;
            }
            
            BaseUIWindowView instance = _resolver.Instantiate(prefab);
            instance.transform.SetParent(transform);

            return instance;
        }
        
        public Dictionary<UIWindowType, BaseUIWindowView> CreateAll(Transform transform)
        {
            foreach (var view in _dictionaryViews.Values)
            {
                BaseUIWindowView instance = _resolver.Instantiate(view);
                instance.transform.SetParent(transform);
                instance.Type = view.Type;
                _allDictionaryViews.Add( instance.Type , instance);
            }

            return _allDictionaryViews;
        }
    }
}