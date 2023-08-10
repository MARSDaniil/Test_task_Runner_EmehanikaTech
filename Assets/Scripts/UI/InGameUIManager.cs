using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Game;
using UI.MenuUI;
using UI.InGame;
using TMPro;

namespace UI.InGame {
    public class InGameUIManager :MonoBehaviour {

        InGameManager _inGameManager;

        [Header("MenuCanvas")]
        [SerializeField] MenuCanvas menuCanvas;
        [Header("InGameCanvas")]
        [SerializeField] InGameCanvas inGameCanvas;

        private void Start() {
            _inGameManager = FindObjectOfType<InGameManager>();
            if (!_inGameManager) {
                UnityEngine.Debug.Log($"{this} has not found {nameof(_inGameManager)}");
            }

            if (_inGameManager.HasStarted)
                Init();
        }
        private void Init() {

            /*
            openPauseMenuButton.onClick.AddListener(OnOpenPauseMenuClicked);
            if (startGame != null) {
                startGame.Open();
                startGame.Init();
            }
            CoinInit();
            */
            menuCanvas.Init(true);
            inGameCanvas.Init();
        }

        public void OpenGame() {
            inGameCanvas.Open();
            menuCanvas.Close();
        }
        public void CloseGame() {
            menuCanvas.Open();
            inGameCanvas.Close();
        }
        /*
        void OnOpenPauseMenuClicked() {
            FreezeGame();
        }

        public void GameOver(string text) {
            gameOverUI.Open();
            gameOverUI.SetGameOverText(text);
            FreezeGame();
        }
        private void CoinInit() {
            coin = 0;
            cointText.text = coin.ToString();
        }
        public void FreezeGame() => _inGameManager.FreezeGame();
        public void UnfreezeGame() => _inGameManager.UnfreezeGame();
        public void PlusCoin() {
            coin++;
            cointText.text = coin.ToString();
        }
        */
    }
}