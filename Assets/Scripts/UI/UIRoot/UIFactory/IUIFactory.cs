using UI.UIRoot;
using UnityEngine;

namespace UI
{
    public interface IUIFactory
    {
        BaseUIWindowView Create(UIWindowType type, Transform transform);
    }
}