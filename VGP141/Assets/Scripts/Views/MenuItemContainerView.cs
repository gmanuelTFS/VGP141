using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class MenuItemContainerView : MonoBehaviour, ICompositeComponent
    {
        [SerializeField]
        private GameObject _subMenu;

        private TextMeshProUGUI _label;
        private List<ICompositeComponent> _components;

        public string Label { get; private set; }

        public Transform Transform => transform;

        // this will be manually called by us
        public void Initialize(string label, List<ICompositeComponent> components)
        {
            Label = label;
            _components = components;

            foreach (var item in _components)
            {
                item.Transform.SetParent(_subMenu.transform, false);
            }
        }

        private void Awake()
        {
            _label = GetComponentInChildren<TextMeshProUGUI>();
        }

        // Start is called before the first frame update
        private void Start()
        {
            _label.text = Label;
            _subMenu.SetActive(false);
        }

        public void AddComponent(ICompositeComponent component)
        {
            _components.Add(component);
        }

        public ICompositeComponent GetChild(int index)
        {
            if (_components.Count == 0 || index < 0 || index >= _components.Count)
            {
                return null;
            }

            return _components[index];
        }

        public void PerformAction()
        {
            _subMenu.SetActive(!_subMenu.activeSelf);
        }

        public void RemoveComponent(ICompositeComponent component)
        {
            _components.Remove(component);
        }
    }
}