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

        [HideInInspector] public InGameCanvas inGameCanvas;
        public override void Init(bool isOpen = false) {
            base.Init(isOpen);
            continueGameButton.onClick.AddListener(ContinueGame);
            menuButton.onClick.AddListener(inGameCanvas.CloseGame);
            restartGameButton.onClick.AddListener(RestartLevel);
        }

        private void ContinueGame() {
            inGameCanvas.ClosePauseMenu();
            inGameCanvas.UnfreezeScore();
            inGameCanvas.inGameUIManager.UnfreezeGame();
        }
        private void RestartLevel() {
            inGameCanvas.inGameUIManager._inGameManager.RestartLevel();
        }
    }
}
