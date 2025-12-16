using System;
using UI.UIRoot;
using UnityEngine;
using VContainer;

namespace UI
{
    public class BaseUIWindowView : MonoBehaviour, IUIWindow
    {
        public UIWindowType Type { get; set; }
        public Action<IUIWindow> OnShowed { get; set; }
        public Action<IUIWindow> OnHided { get; set; }

        [Inject]
        private void Initialize()
        {
        }

        private void Awake()
        {
        }

        public void Show()
        {
            OnShowed?.Invoke(this);
        }

        public void Hide()
        {
            OnHided?.Invoke(this);
        }
    }
}