using UnityEngine;

namespace Template
{
    public class PourOver : BeverageTemplate
    {
        public PourOver(string name) : base(name)
        {
        }

        protected override void Brew()
        {
            Debug.Log("Pouring water over coffee grounds into cup...");
        }

        protected override void PourIntoCup()
        {
        
        }

        protected override void AddCondiments()
        {
            Debug.Log("Adding cream and sugar...");
        }
    }
}
