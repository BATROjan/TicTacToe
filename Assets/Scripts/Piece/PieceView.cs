using UnityEngine;

namespace DefaultNamespace.Piece
{
    public class PieceView : MonoBehaviour
    {
        public PieceType Type
        {
            get => _type;
            set
            {
                _type = value;
            }
        }
        public SpriteRenderer SpriteRenderer
        {
            get => _spriteRenderer;
            set
            {
                _spriteRenderer = value;
            }
        }

        [SerializeField]private SpriteRenderer _spriteRenderer;

        private PieceType _type;
    }
}