using System;
using System.Collections.Generic;
using UnityEngine;

namespace TypeObject
{
    public class MonsterFactory : MonoBehaviour
    {
        [SerializeField] private MonsterView _monsterPrefab;

        private readonly Dictionary<string, Breed> _breedMap = new();

        private void Awake()
        {
            Breed[] allBreeds = Resources.LoadAll<Breed>("TypeObject/Breeds");
            foreach (Breed breed in allBreeds)
            {
                _breedMap.Add(breed.name, breed);
            }
        }

        public MonsterView CreateDragon()
        {
            if (!_breedMap.TryGetValue("Dragon", out Breed dragonBreed))
            {
                throw new InvalidOperationException($"Could not find {nameof(Breed)} with the id Dragon");
            }

            MonsterView dragonView = Instantiate(_monsterPrefab);
            dragonView.Init(dragonBreed.NewMonster());
            return dragonView;
        }

        public MonsterView CreateTroll()
        {
            if (!_breedMap.TryGetValue("Troll", out Breed trollBreed))
            {
                throw new InvalidOperationException($"Could not find {nameof(Breed)} with the id Troll");
            }

            MonsterView createView = Instantiate(_monsterPrefab);
            createView.Init(trollBreed.NewMonster());
            return createView;
        }

        public void OnDragonPressed()
        {
            MonsterView dragonView = CreateDragon();
            dragonView.transform.position = Vector3.left;
            dragonView.Attack();
        }

        public void OnTrollPressed()
        {
            MonsterView trollView = CreateTroll();
            trollView.transform.position = Vector3.right;
            trollView.Attack();
        }
    }
}