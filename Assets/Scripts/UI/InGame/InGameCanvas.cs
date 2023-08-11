using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI.Common;
namespace UI.InGame {
    public class InGameCanvas :MenuWindow {
        [SerializeField] GameOverUI gameOverUI;
        [SerializeField] Score score;
        [SerializeField] PauseMenu pauseMenu;
        [SerializeField] PauseButton pauseButton;

        [HideInInspector] public InGameUIManager inGameUIManager;
        public override void Init(bool isOpen = false) {
            base.Init();
            inGameUIManager = GetComponentInParent<InGameUIManager>();

            SetInGameCanvas();
            SetInitToChild();
        }

        public void OpenPauseMenu() {
            pauseMenu.Open();
            pauseButton.Close();
            score.Close();
            inGameUIManager.FreezeGame();
        }
        public void ClosePauseMenu() {
            pauseMenu.Close();
            pauseButton.Open();
            score.Open();
        }

        public void CloseGame() {
            ClosePauseMenu();
            gameOverUI.Close();
            inGameUIManager.CloseGame();
        }

        private void SetInGameCanvas() {
            pauseButton.inGameCanvas = this;
            pauseMenu.inGameCanvas = this;
        }
        private void SetInitToChild() {
            score.Init(true);
            pauseButton.Init(true);
            gameOverUI.Init();
            pauseMenu.Init();
            pauseMenu.Init();
        }

       
        public void RestartScore() {
            score.StartFire();
        }
        public void UnfreezeScore() => score.ChangeScore(true);

        public void CloseGameOver() =>  gameOverUI.Close();

}
}