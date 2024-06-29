using UnityEngine;

namespace Momento
{
    public class PlayerMomento
    {
        public int Health { get; }
        public int Score { get; }
        public Vector3 Position { get; }
        
        public PlayerMomento(int pHealth, int pScore, Vector3 pPosition)
        {
            Health = pHealth;
            Score = pScore;
            Position = pPosition;
        }
    }
}
