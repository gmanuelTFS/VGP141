using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace VGP141_22S
{
    public class BuildMenuButton : MonoBehaviour
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
        private BuildableData _buildableData;

        public void Initialize(BuildMenu pBuildMenu, BuildableData pBuildableData)
        {
            _buildMenu = pBuildMenu;
            _buildableData = pBuildableData;
            _button.onClick.AddListener(OnClick);
            _label.text = _buildableData.PlayerFacingName;
        }

        private void OnClick()
        {
            // if we have a max build amount, we should check it here
            // Update any visuals appropriately
                // fill, build count
            // Either tell the build menu to create a request or create the request ourselves
        }
    }
}