using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    public class MainMenuUiView: BaseUIWindowView
    {
        public UIDocument UIDocument => _uiDocument;

        [SerializeField] private UIDocument _uiDocument;
        private Label _label;
    }
}