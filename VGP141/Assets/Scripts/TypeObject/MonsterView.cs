using UnityEngine;

namespace TypeObject
{
    public class MonsterView : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        
        private Monster _data;

        public void Init(Monster monster)
        {
            _data = monster;

            _spriteRenderer.sprite = _data.Visual;
        }

        public void Attack()
        {
            Debug.Log(_data.Attack);
        }
    }
}