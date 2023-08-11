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

        /*
        [SerializeField] private float timeBetweenUpSpeed = 10f;
        [SerializeField] private float stepBetweenSpeedUp = 0.1f;
        private bool updateSpeed = true;
        */
        void Awake() {
            Init();
        }

        private void Init() {
            _inGameUIManager.Init(this);
            FreezeGame();
            /*
            levelController.Init(this);
            levelController.GetSpeed(startSpeed);
            */
        }

        void Update() {
        }
        /*
        void FindPlayer() {
            PlayerGameObject = GameObject.FindGameObjectWithTag("Player");
            player = PlayerGameObject.GetComponent<Player>();
            if (PlayerGameObject == null) Debug.LogError($"{player} doesn't contain Player!");
        }
        */


        public void FreezeGame() {
            Time.timeScale = 0;
        }
        public void UnfreezeGame() {
            Time.timeScale = 1;
        }

        /*
        IEnumerator SpeedCoroutine() {
            updateSpeed = false;
            yield return new WaitForSeconds(timeBetweenUpSpeed);
            startSpeed += stepBetweenSpeedUp;
            levelController.GetSpeed(startSpeed);
            updateSpeed = true;
        }
        */
        public void RestartLevel() {
            _inGameUIManager.RestartLevel();
            levelController.SetStartPosition();
        }
    }
}




