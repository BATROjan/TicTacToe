using UI;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Exampple
{
    public class FactoryExampleModel : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Button _button;
        [SerializeField] private BaseUIWindowView uiWindowView;

        public Button Button => _button;

        public BaseUIWindowView UIWindowView => uiWindowView;
    }
}