using System.Collections.Generic;
using UnityEngine;
using Game.Characters.Player;
using UI.InGame;
namespace Game {
    public class InGameManager :MonoBehaviour {
        public bool HasStarted { get; private set; }
        public bool isStartGameClose { get; set; }

        [Header("Player")]
        public GameObject PlayerGameObject;
        Player player;
        [Header("Field")]
       // [SerializeField] ObstacleGenerator obstacleGenerator;
        public Vector2Int sizeOfField;
        public int CountOfObstacle;

        public InGameUIManager _inGameUIManager;

        public List<Vector3> occupiedPositions;

       // [Header("Camera")]
      //  [SerializeField] CameraManager cameraManager;
        void Awake() {
            Init();
            HasStarted = true;
        }

        private void Init() {
           /* player = PlayerGameObject.GetComponent<Player>();
            if (player == null) FindPlayer();
            */
        }

        // Update is called once per frame
        void Update() {
            /*
            if (_inGameUIManager.joystickManager.Direction != new Vector2(0, 0)) player.SetShootManagerAvailible(false);
            else player.SetShootManagerAvailible(true);
            */
            if (isStartGameClose) {
                
            }
            /*
            if (player.IsDead == true) {
                _inGameUIManager.GameOver("u loose");
                isStartGameClose = false;
            }
            */

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
    }
}




