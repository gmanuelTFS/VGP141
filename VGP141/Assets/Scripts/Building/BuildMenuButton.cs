using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VGP141_22S.DesignPatterns;

namespace VGP141_22S
{
    public class BuildMenuButton : MonoBehaviour, IObserver
    {
        /*
         * Callback for when clicked
         * Ability to get the buildable name (initially used on button but can be replaced by a sprite in the future)
         * Fill image management (shows build progress)
         */
        [SerializeField] private Image _fillImage;
        [SerializeField] private Button _button;
        [SerializeField] private TextMeshProUGUI _label;
        
        private BuildMenu _buildMenu;

        public BuildableData BuildableData { get; private set; }

        public void Initialize(BuildMenu pBuildMenu, BuildableData pBuildableData)
        {
            _buildMenu = pBuildMenu;
            BuildableData = pBuildableData;
            _button.onClick.AddListener(OnClick);
            _label.text = BuildableData.PlayerFacingName;
        }

        private void UpdateVisuals(float pRemainingPercentage)
        {
            _fillImage.fillAmount = pRemainingPercentage;
        }

        private void OnClick()
        {
            // TODO: if we have a max build amount, we should check it here
            // Update any visuals appropriately
            _fillImage.fillAmount = 1;
            // TODO: Deal with build count
            // Either tell the build menu to create a request or create the request ourselves
            _buildMenu.CreateBuildRequest(BuildableData, this);
        }

        public void Notify(string pMessage)
        {
            
        }

        public void Notify<T>(string pMessage, T pData)
        {
            switch (pMessage)
            {
                case Notifications.BUILD_REQUEST_REMAINING_TIME_UPDATED when pData is float remainingTime:
                    UpdateVisuals(remainingTime / BuildableData.BuildTime);
                    break;
                case Notifications.BUILD_REQUEST_COMPLETED:
                    UpdateVisuals(0);
                    break;
            }
        }
    }
}