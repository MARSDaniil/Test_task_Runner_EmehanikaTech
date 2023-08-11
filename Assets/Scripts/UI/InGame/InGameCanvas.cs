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

        public InGameUIManager inGameUIManager;
        public override void Init(bool isOpen = false) {
            base.Init();

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
            inGameUIManager.FreezeGame();
            inGameUIManager.CloseGame();
        }

        private void SetInGameCanvas() {
            pauseButton.inGameCanvas = this;
        }
        private void SetInitToChild() {
            score.Init(true);
            pauseButton.Init(true);
            gameOverUI.Init();
            pauseMenu.Init();
            pauseMenu.Init();
        }

        public void GameOver() {
            gameOverUI.Open();
            pauseButton.Close();
            score.Close();
            gameOverUI.SetRecordScore();
            inGameUIManager.FreezeGame();
        }
        
        
        public void RestartScore() {
            score.StartFire();
        }
        public void UnfreezeScore() => score.ChangeScore(true);

        public void CloseGameOver() =>  gameOverUI.Close();

        public void MinusScore() => score.MinusFire();
        public void PlusScore() => score.PlusFire();

        public void SetScore(int value) => gameOverUI.SetCurrScore(value);

    }
}