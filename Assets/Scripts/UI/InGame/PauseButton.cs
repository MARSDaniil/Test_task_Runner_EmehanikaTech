using UnityEngine;
using UI.Common;
using UnityEngine.UI;
namespace UI.InGame {
    public class PauseButton :MenuWindow {
        [SerializeField] Button openPauseMenuButton;
        InGameCanvas inGameCanvas;

        public override void Init(bool isOpen = false) {
            base.Init(isOpen);
            inGameCanvas = GetComponentInParent<InGameCanvas>();
            openPauseMenuButton.onClick.AddListener(inGameCanvas.OpenPauseMenu);
        }
    }
}