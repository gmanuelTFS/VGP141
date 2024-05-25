using Game;
using Game.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class BuildMenuButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _label;
        [SerializeField] private Image _progressImage;

        private BuildQueue _buildQueue;
        private BuildableData _buildableData;

        public void Initialize(BuildQueue pBuildQueue, BuildableData pBuildableData)
        {
            _buildQueue = pBuildQueue;
            _buildableData = pBuildableData;
            _label.text = _buildableData.PlayerFacingName;
            _progressImage.fillAmount = 0;
        }

        public void OnPressed()
        {
            // Set progress to 1.0 to notify the player that this request has been queued
            _progressImage.fillAmount = 1;
            // Create a build request
            BuildRequest buildRequest = new (_buildableData);
            // Register to the progress changed event on the build request
            buildRequest.OnRemainingBuildTimeChanged += OnProgressChanged;
            // Give that request to the build queue
            _buildQueue.Enqueue(buildRequest);
        }

        private void OnProgressChanged(float pRemainingTime)
        {
            _progressImage.fillAmount = pRemainingTime / _buildableData.BuildTime;
        }
    }
}
