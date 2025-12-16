namespace UI.UIRoot
{
    public interface IUIRootConfig
    {
       public UIWindowModel[] _uiRootModels { get; set; }

        BaseUIWindowView GetWindowByType(UIWindowType type);
    }
}