using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using Game.Characters.Player;
using UI.InGame;
namespace Game {
    public class InGameManager :MonoBehaviour {
        public bool HasStarted = false;
        

        [Header("Player")]
        public GameObject PlayerGameObject;
        Player player;

        [Header("Controllers")]
        public InGameUIManager _inGameUIManager;
        public LevelController levelController;

        [Header("SpeedParametrs")]
        [SerializeField] private float startSpeed = 1f;

        void Awake() {
            Init();
        }

        private void Init() {
            _inGameUIManager.Init(this);
            player = PlayerGameObject.GetComponent<Player>();
            FreezeGame();
        }
        public void FreezeGame() {
            Time.timeScale = 0;
        }
        public void UnfreezeGame() {
            Time.timeScale = 1;
        }
        public void RestartLevel() {
            _inGameUIManager.RestartLevel();
            levelController.SetStartPosition();
        }
          
        public void MinusFire() => _inGameUIManager.inGameCanvas.MinusScore();
        public void PlusFire() => _inGameUIManager.inGameCanvas.PlusScore();

    }
}




