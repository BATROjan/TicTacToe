using UnityEngine;

namespace UI
{
    public interface IUIRootView
    {
        Transform ActivateContainer { get; }
        Transform DiactivateContainer{ get; }
    }
}