using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Spawn;
using Game.Obstacle;
namespace Game {
    public class LevelController :MonoBehaviour {
        [Header("Obstacle")]
        [SerializeField] List<GameObject> obstacleList;
        [Header("Barriers")]
        [SerializeField] SpawnBarriers spawnBarriers;

        private float GeneralSpeed;
        private InGameManager _inGameManager;

        public void Init(InGameManager value) {
            _inGameManager = value;
        }
        /*
        public void GetSpeed(float value) {
            if (GeneralSpeed != value) {
                GeneralSpeed = value;
                SetSpeed();
                spawnBarriers.SetSpeed(value);
            }
        }

        private void SetSpeed() {
            /*
            foreach(GameObject o in obstacleList) {
                ObstacleMovement obstacleMovement = o.GetComponent<ObstacleMovement>();
                obstacleMovement.SetSpeed(GeneralSpeed);
            }
            for(int i = 0; i < obstacleList.Count; i++) {
                ObstacleMovement obstacleMovement = obstacleList[i].GetComponent<ObstacleMovement>();
                obstacleMovement.SetSpeed(GeneralSpeed);
            }
        }
        */
    }
}