namespace SuperHeroes
{
    public class LRayVision : SuperPower
    {
        public override void Activate()
        {
            LookL(true);
            LookL(false);
            PlaySound("lRayVisionBloop");
        }
    }
}
