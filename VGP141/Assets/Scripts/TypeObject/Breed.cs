using UnityEngine;

namespace TypeObject
{
    [CreateAssetMenu(fileName = "Breed", menuName = "Patterns/TypeObject/Breed", order = 0)]
    public class Breed : ScriptableObject
    {
        [SerializeField] private int _health;
        [SerializeField] private string _attack;
        [SerializeField] private Sprite _visual;

        public int Health => _health;
        public string Attack => _attack;
        public Sprite Visual => _visual;

        public Monster NewMonster()
        {
            Monster newMonster = new Monster(this);
            return newMonster;
        }
    };
}
