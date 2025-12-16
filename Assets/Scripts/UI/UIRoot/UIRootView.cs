using UnityEngine;
using VContainer;

namespace UI.MainMenuUIWindow
{
    public class UIRootView : MonoBehaviour, IUIRootView
    {
        [field:SerializeField] public Transform ActivateContainer { get; set; }
        [field:SerializeField] public Transform DiactivateContainer { get; set; }
    }
}