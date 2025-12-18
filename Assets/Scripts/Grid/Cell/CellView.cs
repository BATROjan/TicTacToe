using UnityEngine;

namespace DefaultNamespace.Grid.Cell
{
    public class CellView: MonoBehaviour
    {
        public SpriteRenderer SpriteRenderer
        {
            get => _spriteRenderer;
            set
            {
                _spriteRenderer = value;
            }
        }
        [SerializeField] private SpriteRenderer _spriteRenderer;
    }
}