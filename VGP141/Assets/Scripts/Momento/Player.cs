using UnityEngine;

namespace Momento
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private int _score;

        public PlayerMomento CreateMomento()
        {
            return new PlayerMomento(_health, _score, transform.position);
        }

        public void SetMomento(PlayerMomento pPlayerMomento)
        {
            _health = pPlayerMomento.Health;
            _score = pPlayerMomento.Score;
            transform.position = pPlayerMomento.Position;
        }
    }
}
