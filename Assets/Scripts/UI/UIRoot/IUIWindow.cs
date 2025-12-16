using System;
using UI.UIRoot;

namespace UI
{
    public interface IUIWindow
    {
        public UIWindowType Type{ get;}
        public Action<IUIWindow> OnShowed { get; set; }
        public Action<IUIWindow> OnHided{ get; set; }
        void Show();
        void Hide();
    }
}