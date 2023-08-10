
using UnityEngine;
using UnityEngine.UI;
using UI.Common;
namespace UI.MenuUI {
    public class InfoPanel : MenuWindow {
        [SerializeField] Button openInfoButton;
        [SerializeField] Info info;
        public override void Init(bool isOpen = false) {
            base.Init(isOpen);
            info.Init();
            openInfoButton.onClick.AddListener(info.Open);
        }
    }
}