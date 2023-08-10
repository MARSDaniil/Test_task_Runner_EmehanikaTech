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

        private InGameManager _inGameManager;

        [Header("MenuCanvas")]
        [SerializeField] MenuCanvas menuCanvas;
        [Header("InGameCanvas")]
        [SerializeField] InGameCanvas inGameCanvas;

        public void Init(InGameManager value) {
            _inGameManager = value;
            if (!_inGameManager) {
                UnityEngine.Debug.LogError($"{this} has not found {nameof(_inGameManager)}");
            }
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

        public void ContinGameSwitcher(bool value) {
            _inGameManager.HasStarted = value;
        }
       
        void OnOpenPauseMenuClicked() {
            FreezeGame();
        }

        public void FreezeGame() => _inGameManager.FreezeGame();
        public void UnfreezeGame() => _inGameManager.UnfreezeGame();
       
    }
}