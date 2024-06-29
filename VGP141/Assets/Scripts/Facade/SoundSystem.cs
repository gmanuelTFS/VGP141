using UnityEngine;

namespace Facade
{
    public class SoundSystem
    {
        public void TurnOn()
        {
            Debug.Log($"Turning <b><color=green>ON</color></b> {nameof(SoundSystem)}");
        }
    
        public void TurnOff()
        {
            Debug.Log($"Turning <b><color=red>OFF</color></b> {nameof(SoundSystem)}");
        }
    }
}
