using UnityEngine;

namespace TypeObject
{
    public class Monster
    {
        private int _health; // Current health.
        private Breed _breed;

        public int CurrentHealth => _health;
        public Sprite Visual => _breed.Visual;
        public string Attack => _breed.Attack;
        
        public Monster(Breed breed)
        {
            _breed = breed;
            _health = _breed.Health;
        }
    };
}
