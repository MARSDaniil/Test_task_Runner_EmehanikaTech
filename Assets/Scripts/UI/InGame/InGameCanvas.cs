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
            score.Init(true);
            pauseButton.Init(true);
            gameOverUI.Init();
            pauseMenu.Init();
            pauseMenu.Init();
        }

        public void OpenPauseMenu() {
            pauseMenu.Open();
            pauseButton.Close();
            score.Close();
        }
        public void ClosePauseMenu() {
            pauseMenu.Close();
            pauseButton.Open();
            score.Open();
        }

        public void CloseGame() {
            ClosePauseMenu();
            inGameUIManager.CloseGame();
        }
    }
}