using UnityEngine;

namespace Facade
{
    public class LightingSystem
    {
        public void SetLevel(float level)
        {
            Debug.Log($"Setting light level to {level}");
        }
    
        public void TurnOff()
        {
            Debug.Log($"Turning <b><color=red>OFF</color></b> {nameof(LightingSystem)}");
        }
    }
}
