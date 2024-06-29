using UnityEngine;

namespace Facade
{
    public class ProjectorSystem
    {
        public void TurnOn()
        {
            Debug.Log($"Turning <b><color=green>ON</color></b> {nameof(ProjectorSystem)}");
            Debug.Log("Lowering projector screen");
            Debug.Log("Warming up projector");
        }
    
        public void TurnOff()
        {
            Debug.Log($"Turning <b><color=red>OFF</color></b> {nameof(ProjectorSystem)}");
            Debug.Log("Raising projector screen");
            Debug.Log("Turning off projector");
        }
    }
}
