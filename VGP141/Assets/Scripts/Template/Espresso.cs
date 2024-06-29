using UnityEngine;

namespace Template
{
    public class Espresso : BeverageTemplate
    {
        public Espresso(string name) : base(name)
        {
        }

        protected override void BoilWater()
        {
        
        }

        protected override void Brew()
        {
            Debug.Log("Starting espresso machine...");
        }

        protected override void PourIntoCup()
        {

        }

        protected override void AddCondiments()
        {
        
        }
    }
}
