using System;
using UnityEngine;

namespace Facade
{
    public class EntertainmentFacade : MonoBehaviour
    {
        // Movie scenario
            // Lights should go low or off
            // Tv turn off
            // Projector turns on
            // Projector screen comes down
            // Popcorn machine starts
            // Sound system should turn on
        // Weekday Morning scenario
            // Coffee machine turns on and starts
            // Lights turn on to 70%
            // Tv turns on and goes to news channel
        // Gaming scenario
        // Work scenario
        // Off scenario

        private LightingSystem _lightingSystem;
        private RemoteControl _tvSystem;
        private ProjectorSystem _projectorSystem;
        private PopcornMachine _popcornMachine;
        private CoffeeMachine _coffeeMachine;
        private SoundSystem _soundSystem;

        private void Start()
        {
            _lightingSystem = new LightingSystem();
            _tvSystem = new SonyRemoteControl();
            _projectorSystem = new ProjectorSystem();
            _popcornMachine = new PopcornMachine();
            _coffeeMachine = new CoffeeMachine();
            _soundSystem = new SoundSystem();
        }

        public void StartMovieScenario()
        {
            _lightingSystem.SetLevel(0.2f);
            _tvSystem.TurnOff();
            _projectorSystem.TurnOn();
            _popcornMachine.TurnOn();
            _soundSystem.TurnOn();
        }

        public void StartMorningScenario(bool weekday)
        {
            if (!weekday)
            {
                return;
            }
            
            _coffeeMachine.TurnOn();
            _lightingSystem.SetLevel(0.7f);
            _tvSystem.TurnOn();
            _tvSystem.SetChannel(7);
        }

        public void StartOffScenario()
        {
            _lightingSystem.TurnOff();
            _tvSystem.TurnOff();
            _projectorSystem.TurnOff();
            _popcornMachine.TurnOff();
            _coffeeMachine.TurnOff();
            _soundSystem.TurnOff();
        }
    }
}
