using UI.MainMenuUIWindow;
using UI.UIRoot;
using UnityEngine;

namespace UI
{
    public interface IUIFactory
    {
        BaseUIWindowView CreateWindow(UIWindowType type, Transform transform);
    }
}