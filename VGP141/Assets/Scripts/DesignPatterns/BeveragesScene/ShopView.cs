using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class ShopView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _descriptionLabel;
        [SerializeField] private TextMeshProUGUI _costLabel;
        
        private Beverage _currentBeverage;

        private void Start()
        {
            UpdateDisplay();
        }

        public void OnDarkRoastPressed()
        {
            _currentBeverage = new DarkRoast();
            UpdateDisplay();
        }
        
        public void OnDecafPressed()
        {
            _currentBeverage = new Decaf();
            UpdateDisplay();
        }

        public void OnChocolateSyrupPressed()
        {
            _currentBeverage = new ChocolateSyrup(_currentBeverage);
            UpdateDisplay();
        }
        
        public void OnCreamPressed()
        {
            _currentBeverage = new Cream(_currentBeverage);
            UpdateDisplay();
        }
        
        public void OnOatMilkPressed()
        {
            _currentBeverage = new OatMilk(_currentBeverage);
            UpdateDisplay();
        }
        
        public void OnSugarPressed()
        {
            _currentBeverage = new Sugar(_currentBeverage);
            UpdateDisplay();
        }

        public void OnPurchasePress()
        {
            // subtract player money
            // create visual of the drink
            // clear the current beverage
            _currentBeverage = null;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            // A label to display the beverage description
            _descriptionLabel.text = _currentBeverage == null ? string.Empty : _currentBeverage.Description;
            // A label to display the beverage cost
            _costLabel.text = _currentBeverage == null ? string.Empty : $"${_currentBeverage.Cost}";
        }
    }
}