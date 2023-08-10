
using UnityEngine;
using UnityEngine.UI;
using UI.Common;
namespace UI.MenuUI {
    public class Info :MenuWindow {
        [SerializeField] Button closeInfoButton;

        public override void Init(bool isOpen = false) {
            base.Init(isOpen);
            closeInfoButton.onClick.AddListener(Close);
        }
    }   
}