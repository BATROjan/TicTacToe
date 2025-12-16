using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UI.UIRoot
{
    [CreateAssetMenu(fileName = "UIRootConfig", menuName = "configs/UIRootConfig")]
    public class UIRootConfig: ScriptableObject
    {
        
        [SerializeField] private UIWindowModel[] _uiRootModels;

        private Dictionary<UIWindowType, BaseUIWindowView> _viewsDictionary;
        public  Dictionary<UIWindowType, BaseUIWindowView> GetDictionaryVies()
        {
            Init();
            return _viewsDictionary;
        }

        private void Init()
        {
            if (_viewsDictionary == null)
            {
                _viewsDictionary = new();
                foreach (var model in _uiRootModels)
                {
                    _viewsDictionary.Add(model.UiWindowType, model.WindowView);
                }
            }
        }
    }
    
    [Serializable]
    public struct UIWindowModel
    {
        public UIWindowType UiWindowType;
        public BaseUIWindowView WindowView;
    }
    public enum UIWindowType
    {
        MainMenu
    }
}