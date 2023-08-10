using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UI.Common;
namespace UI.InGame {
    public class PauseMenu :MenuWindow {
        [SerializeField] Button continueGameButton;
        [SerializeField] Button menuButton;
        [SerializeField] Button restartGameButton;
        [SerializeField] Button settingButton;

        InGameCanvas inGameCanvas;
        public override void Init(bool isOpen = false) {
            base.Init(isOpen);
            inGameCanvas = GetComponentInParent<InGameCanvas>();
            continueGameButton.onClick.AddListener(inGameCanvas.ClosePauseMenu);
            menuButton.onClick.AddListener(inGameCanvas.CloseGame);
        }
    }
}
