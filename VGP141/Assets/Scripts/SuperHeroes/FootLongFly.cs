using UnityEngine;

namespace SuperHeroes
{
    public class FootLongFly : SuperPower
    {
        public override void Activate()
        {
            MovePlayer(Vector3.up * 0.3048f);
            PlaySound("BigWhoosh");
        }
    }
}
