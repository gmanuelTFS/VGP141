using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class MenuView : MonoBehaviour
    {
        // Build our menu by instantiating menu item views

        [SerializeField]
        private MenuItemView _menuItemViewPrefab;

        [SerializeField]
        private MenuItemContainerView _menuItemContainerViewPrefab;

        private void Awake()
        {
        }

        private void Start()
        {
            // menu item M1
            // menu item M2
            // container C1
                // menu item C1S1
                // container C1S2
                    // menu item C1S2S1
                    // menu item C1S2S2
            // menu item M3

            MenuItemView m1 = Instantiate(_menuItemViewPrefab, transform);
            m1.Initialize("m1");

            MenuItemView m2 = Instantiate(_menuItemViewPrefab, transform);
            m2.Initialize("m2");

            MenuItemView c1s1 = Instantiate(_menuItemViewPrefab);
            MenuItemView c1s2s1 = Instantiate(_menuItemViewPrefab);
            c1s2s1.Initialize("c1s2s1");
            MenuItemView c1s2s2 = Instantiate(_menuItemViewPrefab);
            c1s2s2.Initialize("c1s2s2");
            MenuItemContainerView c1s2 = Instantiate(_menuItemContainerViewPrefab);
            c1s2.Initialize("c1s2", new List<ICompositeComponent> { c1s2s1, c1s2s2 });
            MenuItemContainerView c1 = Instantiate(_menuItemContainerViewPrefab, transform);
            c1.Initialize("c1", new List<ICompositeComponent> { c1s1, c1s2 });
            c1s1.Initialize("c1s1");

            MenuItemView m3 = Instantiate(_menuItemViewPrefab, transform);
            m3.Initialize("m3");
        }
    }
}