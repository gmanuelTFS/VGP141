using UnityEngine;

namespace Facade
{
    public class CoffeeMachine
    {
        public void TurnOn()
        {
            Debug.Log($"Turning <b><color=green>ON</color></b> {nameof(CoffeeMachine)}");
        }
    
        public void TurnOff()
        {
            Debug.Log($"Turning <b><color=red>OFF</color></b> {nameof(CoffeeMachine)}");
        }
    }
}
