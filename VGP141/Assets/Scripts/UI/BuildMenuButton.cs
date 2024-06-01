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
        [SerializeField] private TextMeshProUGUI _countLabel;

        private BuildQueue _buildQueue;
        private BuildableData _buildableData;
        private uint _queueCount;

        public void Initialize(BuildQueue pBuildQueue, BuildableData pBuildableData)
        {
            _buildQueue = pBuildQueue;
            _buildableData = pBuildableData;
            _label.text = _buildableData.PlayerFacingName;
            _progressImage.fillAmount = 0;
            UpdateCountLabel(0);
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
            UpdateCountLabel(++_queueCount);
        }

        private void UpdateCountLabel(uint pCount)
        {
            _countLabel.text = pCount.ToString();
            _countLabel.gameObject.SetActive(pCount > 1);
        }

        private void OnProgressChanged(float pRemainingTime)
        {
            _progressImage.fillAmount = pRemainingTime / _buildableData.BuildTime;
            if (pRemainingTime != 0)
            {
                return;
            }
            
            UpdateCountLabel(--_queueCount);
        }
    }
}
