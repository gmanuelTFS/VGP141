using UnityEngine;

namespace Facade
{
    public class PopcornMachine
    {
        public void TurnOn()
        {
            Debug.Log($"Turning <b><color=green>ON</color></b> {nameof(PopcornMachine)}");
        }
    
        public void TurnOff()
        {
            Debug.Log($"Turning <b><color=red>OFF</color></b> {nameof(PopcornMachine)}");
        }
    }
}
