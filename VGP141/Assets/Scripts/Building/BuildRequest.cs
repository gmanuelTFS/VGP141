using System;
using VGP141_22S.DesignPatterns;

namespace VGP141_22S
{
    public class BuildRequest : Subject
    {
        public readonly BuildableData BuildableData;
        public float RemainingBuildTime { get; private set; }

        public BuildRequest(BuildableData pBuildableData)
        {
            BuildableData = pBuildableData;
            RemainingBuildTime = BuildableData.BuildTime;
        }

        public void ModifyRemainingTime(float pModification)
        {
            RemainingBuildTime -= pModification;
            if (RemainingBuildTime < 0)
            {
                RemainingBuildTime = 0;
                NotifyObservers(Notifications.BUILD_REQUEST_COMPLETED, this);
            }
            else
            {
                NotifyObservers(Notifications.BUILD_REQUEST_REMAINING_TIME_UPDATED, RemainingBuildTime);
            }
        }
    }   
}
