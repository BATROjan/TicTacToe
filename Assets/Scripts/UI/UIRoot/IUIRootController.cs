namespace UI.UIRoot
{
    public interface IUIRootController
    {
        BaseUIWindowView SpawnWindow(UIWindowType type);
        void ShowWindow(UIWindowType type);
        void HideWindow(UIWindowType type);
        BaseUIWindowView GetWindow(UIWindowType type);
    }
}