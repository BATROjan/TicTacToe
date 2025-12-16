using System;
using UI;
using UI.UIRoot;using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using VContainer.Unity;

public class MainMenuWindowUIController : IStartable
{
    private readonly IUIRootController _uiRootController;
    private readonly MainMenuUiView mainMenuUiView;
    private readonly UIDocument _uiDocument;
    
    private Label _label;

    private int _count;
    
    public MainMenuWindowUIController(IUIRootController uiRootController)
    {
        _uiRootController = uiRootController;
        mainMenuUiView = (MainMenuUiView)_uiRootController.GetWindow(UIWindowType.MainMenu);
        _uiDocument = mainMenuUiView.UIDocument;

    }

    public void Start()
    {
        mainMenuUiView.OnShowed += ShowWindow;
    }

    private void ShowWindow(IUIWindow window)
    {
        _label = _uiDocument.rootVisualElement.Q<Label>("Count");
        var addButton = _uiDocument.rootVisualElement.Q<Button>("AddButton");
        var resetButton = _uiDocument.rootVisualElement.Q<Button>("ResetButton");
        
        addButton.RegisterCallback<ClickEvent>(Add);
        resetButton.RegisterCallback<ClickEvent>(Reset);
    }

    private void Add(ClickEvent e)
    {
        _count++;
        _label.text = _count.ToString();
    }

    private void Reset(ClickEvent e)
    {
        _count = 0;
        _label.text = _count.ToString();
    }

}
