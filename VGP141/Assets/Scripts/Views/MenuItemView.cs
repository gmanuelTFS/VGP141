using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class MenuItemView : MonoBehaviour, ICompositeComponent
    {
        private TextMeshProUGUI _label;

        public string Label { get; private set; }

        public Transform Transform => transform;

        public void AddComponent(ICompositeComponent component)
        {

        }

        public ICompositeComponent GetChild(int index)
        {
            return null;
        }

        public void PerformAction()
        {
            Debug.Log($"Performing Action - {Label}");
        }

        public void RemoveComponent(ICompositeComponent component)
        {

        }

        // this will be manually called by us
        public void Initialize(string label)
        {
            Label = label;
        }

        private void Awake()
        {
            _label = GetComponentInChildren<TextMeshProUGUI>();
        }

        // Start is called before the first frame update
        private void Start()
        {
            _label.text = Label;
        }
    }
}