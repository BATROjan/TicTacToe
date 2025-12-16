using System;
using UI;
using UI.UIRoot;using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using VContainer.Unity;

public class MainMenuWindowUIController : IStartable
{
    private readonly IUIRootController _uiRootController;
    private readonly MainMenuUiView mainMenuUiView;
    private readonly UIDocument _uiDocument;
    
    private Label _label;
    
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
        _label = _uiDocument.rootVisualElement.Q<Label>("NameText");
        var startButton = _uiDocument.rootVisualElement.Q<Button>("StartButton");
        
        startButton.RegisterCallback<ClickEvent>(StartGame);
        _label.text = "TicTacToe";
    }

    private void StartGame(ClickEvent e)
    {
        SceneManager.LoadScene("GameScene");
    }
}
